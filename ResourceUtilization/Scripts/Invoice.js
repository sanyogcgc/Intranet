$(document).ready(function () {
    ShowGrid();
    $(window.paramFromView.GridId).hideCol("Id");
    $('#dvBtn').fadeOut();
});
$("#btnUpdate").click(function () {
    var invoiceResult = [];
    var Pid = $("#ddlProject").val();
    var weekNumber = $("#ddlWeek").val();
    var yearNumber = $("#ddlYear").val();
    var k = 1;
    var rows = $(window.paramFromView.GridId).jqGrid('getRowData');
    var j = 1;
    $.each(rows, function (index, value) {
        var rowData = value;
        var invoiceHours = $("#T" + 3 + "_" + j).val();
        var empId = $("#T" + 4 + "_" + j).val();
        var Status = false;
        var Year = yearNumber;
        j++;

        invoiceResult.push({ ProjectId: Pid, Emp_Id: empId, InvoiceHours: invoiceHours, iStatus: Status, WeekNumber: weekNumber, Year: Year });

    });
    if (weekNumber.length > 0) {
        $.ajax({
            type: 'POST',
            url: '/Home/InsertInvoiceDetail',
            data: { invoiceViewModel: invoiceResult },
            dataType: 'application/json; charset=utf-8',
            success: function (response) {
                if (response != null && response.success) {
                    alert(response);
                } else {
                    alert(response);
                }
            },
            error: function (response) {

                $(window.paramFromView.GridId).clearGridData();
                $(window.paramFromView.GridId).jqGrid("setGridParam", { postData: { 'projectId': $("#ddlProject").val(), 'weekNumber': $('#ddlWeek').val() }, datatype: "json" }).trigger("reloadGrid");

            }

        });
    }
    else {
        alert('please select Week');
    }


});
$("#btnSubmit").click(function () {
    var invoiceResult = [];
    var Pid = $("#ddlProject").val();
    var weekNumber = $("#ddlWeek").val();
    var yearNumber = $("#ddlYear").val();
    var k = 1;
    var rows = $(window.paramFromView.GridId).jqGrid('getRowData');
    var count = 0;
    var i = 1;
    $.each(rows, function (index, value) {
        //var rowDa = value;
        var plannedHours = $("#T" + 1 + "_" + i).val();
        var actualHours = $("#T" + 2 + "_" + i).val();
        var invoiceHours = $("#T" + 3 + "_" + i).val();
        var sum = 0;
        sum = parseInt(plannedHours) + parseInt(actualHours) + parseInt(invoiceHours);
        if (sum > 40)
            count++
    })
    if (count > 0)
        alert('More than 40 Hours');
    var j = 1;
    $.each(rows, function (index, value) {
        var rowData = value;
        var invoiceHours = $("#T" + 3 + "_" + j).val();
        var empId = $("#T" + 4 + "_" + j).val();
        var Status = true;
        var Year = yearNumber;
        j++;

        invoiceResult.push({ ProjectId: Pid, Emp_Id: empId, InvoiceHours: invoiceHours, iStatus: Status, WeekNumber: weekNumber, Year: Year });

    });
    //alert(JSON.stringify(invoiceResult));
    $.ajax({
        type: 'POST',
        url: '/Home/InsertInvoiceDetail',
        data: { invoiceViewModel: invoiceResult },
        dataType: 'application/json; charset=utf-8',
        success: function (response) {
            if (response != null && response.success) {
                alert(response);
            } else {
                alert(response);
            }
        },
        error: function (response) {
          
            $(window.paramFromView.GridId).clearGridData();
            $(window.paramFromView.GridId).jqGrid("setGridParam", { postData: { 'projectId': $("#ddlProject").val(), 'weekNumber': $('#ddlWeek').val() }, datatype: "json" }).trigger("reloadGrid");

            $('#btnUpdate').hide();
            $('#btnSubmit').hide();
            // getdata();
        }

    });

});

function ShowGrid() {
    var prjId = $('#ddlProject').val();
    var weekNumber = $('#ddlWeek').val();
    var year = $('#ddlYear').val();

    $(window.paramFromView.GridId).jqGrid({
        loadError: function (xhr, status, error) {
            alert('load error: ' + error);
        },
        datatype: 'json',
        colNames: ['Id', 'Employee Id', 'Name', 'Designation', 'Planned Hours', 'Actual Hours', 'Invoice Hours'],
        colModel: [
          { name: 'Id', index: 'Id', width: 100, align: 'left' },
          { name: 'Emp_Id', index: 'Emp_Id', width: 100, align: 'left' },
          { name: 'EmployeeName', index: 'EmployeeName', width: 200, align: 'left' },
          { name: 'DesignationName', index: 'DesignationName', width: 200, align: 'left' },
          { name: 'PlannedHours', index: 'PlannedHours', width: 100, align: 'left' },
          { name: 'ActualHours', index: 'ActualHours', width: 100, align: 'left' },
          { name: 'InvoiceHours', index: 'InvoiceHours', width: 100, align: 'left' }, ],

        hidegrid: false,
        sortname: 'Name',
        sortorder: "asc",
        datatype: 'json',
        viewrecords: true,
        gridview: true,
        mtype: 'POST',
        rownumbers: true,
        rownumWidth: 35,
        rowNum: -1,
        jsonReader: {
            root: "rows",
            id: "Id",
            page: "page",
            total: "total",
            records: "records",
            repeatitems: false,
            userdata: "userdata"
        },
        url: window.paramFromView.Url,
        postData: {},
        data: {},
        emptyDataText: window.paramFromView.DataNotAvaliable,
        caption: 'Resource Planning'
    });

};
function getdata() {
    $.ajax({
        type: 'POST',
        url: '/Home/hideANDshowInvoice',
        data: { 'projectId': $("#ddlProject").val(), 'weekNumber': $('#ddlWeek').val(), 'year': $('#ddlYear').val() },
        success: function (response) {
            $(window.paramFromView.GridId).clearGridData();
            $('#dvBtn').attr("style", 'block')
            if (response == "True") {
                $('#btnUpdate').hide();
                $('#btnSubmit').hide();
            } else {
                $('#btnUpdate').show();
                $('#btnSubmit').show();
            }

        },
        error: function (response) {
            $(window.paramFromView.GridId).clearGridData();
            alert("Please select project !!!");
        }

    });
    $(window.paramFromView.GridId).clearGridData();
    $(window.paramFromView.GridId).jqGrid("setGridParam", { postData: { 'projectId': $("#ddlProject").val(), 'weekNumber': $('#ddlWeek').val(), 'Year': $('#ddlYear').val() }, datatype: "json" }).trigger("reloadGrid");
}
function fillWeek() {
    $(window.paramFromView.GridId).clearGridData();
    var year = $('#ddlYear').val();
    $.ajax({
        url: '/Home/fillWeek',
        type: "GET",
        dataType: "JSON",
        data: { year: year },
        success: function (years) {
            $("#ddlWeek").html("");
            $.each(years, function (i, year) {
                $("#ddlWeek").append(
                    $('<option></option>').val(year.Value).html(year.Text));
            });
        }
    });
}

function ClearGrid()
{
    $(window.paramFromView.GridId).clearGridData();
   // $('#ddlYear').text() == '--Select Year--';
  //  $('#ddlYear option[value=""]').attr("selected", true);
}

