using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace DataAccess.DAL
{
    public class ResourceUtilizationDa : BaseDa
    {
        public ResourceUtilizationDa(IUnitOfWork unityOfWork)
            : base(unityOfWork)
        {
        }
        public string GetWeek(int? weeknumber, int year)
        {
            DateTime dt = new DateTime(year, 1, 1).AddDays((Convert.ToInt32(weeknumber) - 1) * 7);

            while (dt.DayOfWeek != CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
                dt = dt.AddDays(-1);

            return string.Format("{0:MM/dd/yyyy},{1:MM/dd/yyyy}", dt.AddDays(1), dt.AddDays(7));
        }
        public List<IEnumerable<ResourceViewModel>> GetResouces(int? projectId = 0, int? weekNumber = 0, int? year = 0)
        {
            try
            {
                //var nextweek = from prv in UnitOfWork.ResourceUtilizationRepository.GetQuery()
                //               where prv.WeekNumber == weekNumber - 1 && prv.ProjectId == projectId
                //               select new
                //               {
                //                   CurrentBillable = prv.CurrentBillable,
                //                   CurrentNonBillable = prv.CurrentNonBillable,
                //                   Status = prv.Status,
                //                   Emp_Id = prv.Emp_Id
                //               };
                //var data = from x in UnitOfWork.ResourceUtilizationRepository.GetQuery()
                //           where x.WeekNumber == weekNumber && x.ProjectId == projectId && x.Year == year
                //           select new ResourceViewModel
                //      {
                //          Id = x.ID,
                //          ResourceId = x.Emp_Id,
                //          ProjectId = x.ProjectId,
                //          CurrentBillable = x.CurrentBillable,
                //          CurrentNonBillable = x.CurrentNonBillable,
                //          NextBillable = nextweek.Where(a => a.Emp_Id == x.Emp_Id).FirstOrDefault().CurrentBillable,
                //          NextNonBillable = nextweek.Where(a => a.Emp_Id == x.Emp_Id).FirstOrDefault().CurrentNonBillable,
                //          InvoiceHours = x.InvoiceHours,
                //          Status = x.Status
                //         // Status = nextweek.Where(a => a.Emp_Id == x.Emp_Id).FirstOrDefault().Status
                //      };
                var Previousweek = (from prv in UnitOfWork.ResourceUtilizationRepository.GetQuery()
                               where prv.WeekNumber == weekNumber - 1 && prv.ProjectId == projectId
                                   select new ResourceViewModel()
                               {
                                   Id = prv.ID,
                                   ResourceId = prv.Emp_Id,
                                   PreviousBillable = prv.CurrentBillable,
                                   PreviousNonBillable = prv.CurrentNonBillable,
                                   Status = prv.Status,
                                   Emp_Id = prv.Emp_Id,
                                   InvoiceHours = prv.InvoiceHours
                               }).ToList();
                var data =( from x in UnitOfWork.ResourceUtilizationRepository.GetQuery()
                           where x.WeekNumber == weekNumber && x.ProjectId == projectId && x.Year == year
                           select new ResourceViewModel()
                      {
                          Id = x.ID,
                          ResourceId = x.Emp_Id,
                          ProjectId = x.ProjectId,
                          CurrentBillable = x.CurrentBillable,
                          CurrentNonBillable = x.CurrentNonBillable,
                          //PreviousBillable = Previousweek.Where(a => a.Emp_Id == x.Emp_Id).FirstOrDefault().CurrentBillable,
                          //PreviousNonBillable = Previousweek.Where(a => a.Emp_Id == x.Emp_Id).FirstOrDefault().CurrentNonBillable,
                          InvoiceHours = x.InvoiceHours,
                          Status = x.Status
                          // Status = nextweek.Where(a => a.Emp_Id == x.Emp_Id).FirstOrDefault().Status
                      }).ToList();


                //var ttlData =( from o in Previousweek
                //              from ods in data
                //                  .Where(details => o.ResourceId == details.ResourceId)
                //                  .DefaultIfEmpty()
                //              select new ResourceViewModel()
                //              {
                //                  Id = ods.Id,
                //                  ResourceId = o.Emp_Id,
                //                  ProjectId = o.ProjectId,
                //                  PreviousBillable = o.PreviousBillable,
                //                  PreviousNonBillable= o.PreviousNonBillable,
                //                  CurrentBillable= ods.CurrentBillable,
                //                  CurrentNonBillable= ods.CurrentNonBillable,
                //                  InvoiceHours = ods.InvoiceHours,
                //                  Status = ods.Status
                              
                //              }).ToList();


                //IEnumerable<ResourceViewModel>[] AddData=null;
                //AddData[0] = Previousweek.ToList();
                //AddData[1] = data.ToList();

                //return AddData;
                List<IEnumerable<ResourceViewModel>> items = new List<IEnumerable<ResourceViewModel>>();
                items.Add(Previousweek);
                items.Add(data);
                //items.Add(ttlData);
                return items;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsertBulk(List<ResourceViewModel> resources, int currentUser)
        {
            try
            {
                ResourceUtilization ru1 = new ResourceUtilization();
                ru1 = UnitOfWork.ResourceUtilizationRepository.GetQuery().ToList().FirstOrDefault(x => x.WeekNumber == resources.FirstOrDefault().WeekNumber  && x.ProjectId == resources.FirstOrDefault().ProjectId);
                if (ru1 != null)
                {
                    foreach (var item in resources.ToList().Select(x => new ResourceUtilization() { ID = Convert.ToInt32(x.Id), Emp_Id = x.Emp_Id, CurrentBillable = Convert.ToInt32(x.CurrentBillable), CurrentNonBillable = Convert.ToInt32(x.CurrentNonBillable), InvoiceHours = Convert.ToInt32(x.InvoiceHours), ProjectId = Convert.ToInt32(x.ProjectId), CreatedDate = System.DateTime.Now, Status = Convert.ToBoolean(x.Status), WeekNumber = Convert.ToInt32(x.WeekNumber), Year = Convert.ToInt32(x.Year), ModifiedBy = currentUser }).ToList())
                    {
                        ResourceUtilization ru = new ResourceUtilization();
                        ru = UnitOfWork.ResourceUtilizationRepository.GetQuery().ToList().FirstOrDefault(x => x.WeekNumber == item.WeekNumber  && x.Emp_Id == item.Emp_Id && x.ProjectId == item.ProjectId);
                        if (ru != null)
                        {
                            ru = UnitOfWork.ResourceUtilizationRepository.GetQuery().ToList().FirstOrDefault(x => x.WeekNumber == item.WeekNumber  && x.Emp_Id == item.Emp_Id && x.ProjectId == item.ProjectId);
                            ru.CurrentBillable = item.CurrentBillable;
                            ru.CurrentNonBillable = item.CurrentNonBillable;
                            ru.InvoiceHours = item.InvoiceHours;
                            ru.ProjectId = item.ProjectId;
                            ru.WeekNumber = item.WeekNumber;// +1;
                            ru.Year = item.Year;
                            ru.Emp_Id = item.Emp_Id;
                            ru.ModifiedDate = System.DateTime.Now;
                            ru.Status = item.Status;
                            ru.ModifiedBy = currentUser;
                            UnitOfWork.ResourceUtilizationRepository.Update(ru);
                            UnitOfWork.ResourceUtilizationRepository.context.SaveChanges();
                        }
                    }
                }
                else
                {
                    UnitOfWork.ResourceUtilizationRepository.BulkInsert(resources.ToList().Select(x => new ResourceUtilization() { Emp_Id = x.Emp_Id, CurrentBillable = Convert.ToInt32(x.CurrentBillable), CurrentNonBillable = Convert.ToInt32(x.CurrentNonBillable), InvoiceHours = Convert.ToInt32(x.InvoiceHours), ProjectId = Convert.ToInt32(x.ProjectId), CreatedDate = System.DateTime.Now, Status = Convert.ToBoolean(x.Status), WeekNumber = Convert.ToInt32(x.WeekNumber), Year = Convert.ToInt32(x.Year), CreatedBy = currentUser }).ToList());
                    UnitOfWork.ResourceUtilizationRepository.context.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool GetStatus(int projectId = 0, int weekNumber = 0, int year = 0)
        {
            var data = UnitOfWork.ResourceUtilizationRepository.GetQuery().ToList().FirstOrDefault(x => x.WeekNumber == weekNumber && x.ProjectId == projectId && x.Year == year);
            if (data != null)
            {
                return Convert.ToBoolean(data.Status);
            }
            else
            {
                return false;
            }
        }

    }
}