using ResourceUtilization.HtmlHelpers.Grid;
using ResourceUtilization.Utility;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;

namespace ResourceUtilization.Controllers
{
    public class BaseController : Controller
    {
        public static int GetWeekNumber(DateTime dtPassed)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }
        public List<WeekViewModel> GetNumberOfweekList(int weekNumber, int year)
        {
            List<WeekViewModel> week = new List<WeekViewModel>();
            for (int i = 1; i <= weekNumber; i++)
            {
                week.Add(new WeekViewModel { Text = "Week:" + i + "( " + GetWeek(i, year) + " )", Value = i });
            }
            return week;

        }
        public int GetWeeksInYear(int year)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            DateTime date1 = new DateTime(year, 12, 20);
            Calendar cal = dfi.Calendar;
            var a = cal.GetWeekOfYear(date1, dfi.CalendarWeekRule,
                                                dfi.FirstDayOfWeek);
            return cal.GetWeekOfYear(date1, dfi.CalendarWeekRule,
                                                dfi.FirstDayOfWeek);
        }
        public List<YearViewModel> YearList()
        {
            List<YearViewModel> year = new List<YearViewModel>();
            year.Add(new YearViewModel { Text = Convert.ToString(Convert.ToInt32(DateTime.Now.Year.ToString()) - 1), Value = DateTime.Now.Year - 1 });
            year.Add(new YearViewModel { Text = DateTime.Now.Year.ToString(), Value = DateTime.Now.Year });
            return year;

        }

        public List<WorkLogDateViewModel> WorkDaysList()
        {
            List<WorkLogDateViewModel> WorkDays = new List<WorkLogDateViewModel>();
            for (int i = 0; i < 30; i++)
            {
                //WorkDays.Add(new WorkLogDateViewModel { Text = Convert.ToString(Convert.ToInt32(DateTime.Now.Date) - i), Value = Convert.ToString(Convert.ToInt32(DateTime.Now.Date) - i) });
                WorkDays.Add(new WorkLogDateViewModel { Text = DateTime.Now.Date.AddDays((-1) * i).ToString("MM/dd/yyyy"), Value = DateTime.Now.Date.AddDays((-1) * i).ToString("MM/dd/yyyy") });
            }
            return WorkDays;
        }

        public List<PhaseViewModel> WorkLogPhaseList()
        {
            List<PhaseViewModel> Phase = new List<PhaseViewModel>();
            Phase.Add(new PhaseViewModel { PhaseId = 0, PhaseName = "----Select----" });
            return Phase;
        }
        public List<EmployeeDetailViewModel> EmployeeListforTech()
        {
            List<EmployeeDetailViewModel> emp = new List<EmployeeDetailViewModel>();
            emp.Add(new EmployeeDetailViewModel { Emp_Id=0, EmpName="----Select----" });
            return emp;
        }
        public List<ModuleViewModel> WorkLogModuleList()
        {
            List<ModuleViewModel> Module = new List<ModuleViewModel>();
            Module.Add(new ModuleViewModel { ProjModule_Id = 0, ModuleName = "----Select-----", PhaseId = 0, ProjectId = 0 });
            return Module;
        }
        public List<TaskViewModel> WorkLogTaskList()
        {
            List<TaskViewModel> task = new List<TaskViewModel>();
            task.Add(new TaskViewModel { ProjTask_Id =0, TaskName="----Select----", Phase =0, ProjectId =0 });
            return task;
        }

        public List<TimeSpentViewModel> WorkLogTimeSpentInterval()
        {
            List<TimeSpentViewModel> List1 = new List<TimeSpentViewModel>();
            List1.Add(new TimeSpentViewModel { value = "0", text = "----Select----" });
            List1.Add(new TimeSpentViewModel { value = "00:15", text = "00:15" });
            List1.Add(new TimeSpentViewModel { value = "00:30", text = "00:30" });
            List1.Add(new TimeSpentViewModel { value = "00:45", text = "00:45" });
            List1.Add(new TimeSpentViewModel { value = "01:00", text = "01:00" });
            List1.Add(new TimeSpentViewModel { value = "01:15", text = "01:15" });
            List1.Add(new TimeSpentViewModel { value = "01:30", text = "01:30" });
            List1.Add(new TimeSpentViewModel { value = "01:45", text = "01:45" });
            List1.Add(new TimeSpentViewModel { value = "02:00", text = "02:00" });
            List1.Add(new TimeSpentViewModel { value = "02:15", text = "02:15" });
            List1.Add(new TimeSpentViewModel { value = "02:30", text = "02:30" });
            List1.Add(new TimeSpentViewModel { value = "02:45", text = "02:45" });
            List1.Add(new TimeSpentViewModel { value = "03:00", text = "03:00" });
            List1.Add(new TimeSpentViewModel { value = "03:15", text = "03:15" });
            List1.Add(new TimeSpentViewModel { value = "03:30", text = "03:30" });
            List1.Add(new TimeSpentViewModel { value = "03:45", text = "03:45" });
            List1.Add(new TimeSpentViewModel { value = "04:00", text = "04:00" });
            List1.Add(new TimeSpentViewModel { value = "04:15", text = "04:15" });
            List1.Add(new TimeSpentViewModel { value = "04:30", text = "04:30" });
            List1.Add(new TimeSpentViewModel { value = "04:45", text = "04:45" });
            List1.Add(new TimeSpentViewModel { value = "05:00", text = "05:00" });
            List1.Add(new TimeSpentViewModel { value = "05:15", text = "05:15" });
            List1.Add(new TimeSpentViewModel { value = "08:30", text = "05:30" });
            List1.Add(new TimeSpentViewModel { value = "05:45", text = "05:45" });
            List1.Add(new TimeSpentViewModel { value = "06:00", text = "06:00" });
            List1.Add(new TimeSpentViewModel { value = "06:00", text = "05:00" });
            List1.Add(new TimeSpentViewModel { value = "06:15", text = "05:15" });
            List1.Add(new TimeSpentViewModel { value = "06:30", text = "05:30" });
            List1.Add(new TimeSpentViewModel { value = "06:45", text = "05:45" });
            List1.Add(new TimeSpentViewModel { value = "07:00", text = "06:00" });



            return List1;
        }
        public string GetWeek(int weeknumber, int year)
        {
            DateTime dt = new DateTime(year, 1, 1).AddDays((weeknumber) * 7);
            while (dt.DayOfWeek != CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
                dt = dt.AddDays(-1);
            return string.Format("{0:MM/dd/yyyy}-{1:MM/dd/yyyy}", dt.AddDays(1), dt.AddDays(7));
        }


        /// <summary>
        /// Returns the sorted result.
        /// </summary>
        /// <param name="rows">The rows.</param>
        /// <param name="grid">The grid.</param>
        /// <param name="isPagingRequired">if set to <c>true</c> [is paging required].</param>
        /// <param name="grandTotal">The grand total.</param>
        /// <returns>
        /// JsonResult.
        /// </returns>
        public JsonResult ReturnSortedResult(object[] rows, GridSettings grid, decimal grandTotal = 0)
        {
            IEnumerable<object> sortedList = rows;
            if (grid.SortOrder.ToLower() == Constants.SortAsc)
                sortedList =
                    (from r in rows
                     orderby rows[0].GetType().GetProperty(grid.SortColumn).GetValue(r, null)
                     select r);
            else
                sortedList =
                    (from r in rows
                     orderby rows[0].GetType().GetProperty(grid.SortColumn).GetValue(r, null) descending
                     select r);
            

            var result = new
            {
                total = grid.PageSize>-1? (int)Math.Ceiling((double)rows.Count() / grid.PageSize):1,
                page = grid.PageIndex,
                records = rows.Count(),
                rows = sortedList.ToArray(),
                grandTotal = grandTotal
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}