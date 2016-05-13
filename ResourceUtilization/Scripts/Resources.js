$(document).ready(function () {
    ShowGrid();
    $(window.paramFromView.GridId).jqGrid("setLabel", "rn", "SNo.");
    $(window.paramFromView.GridId).hideCol("Id");
    $(window.paramFromView.GridId).hideCol("InvoiceHours");
    var gw = $(window.paramFromView.GridId).jqGrid('getGridParam', 'width');
    if ($('#rdlBillable').is(":checked")) {
        $(window.paramFromView.GridId).hideCol("CurrentNonBillable");
        $(window.paramFromView.GridId).hideCol("NextNonBillable");
        $(window.paramFromView.GridId).showCol("CurrentBillable");
        $(window.paramFromView.GridId).showCol("NextBillable");
    }
    if ($('#rdlNonBillable').is(":checked")) {
        $(window.paramFromView.GridId).showCol("CurrentNonBillable");
        $(window.paramFromView.GridId).showCol("NextNonBillable");
        $(window.paramFromView.GridId).hideCol("CurrentBillable");
        $(window.paramFromView.GridId).hideCol("NextBillable");
    }
    $(window.paramFromView.GridId).jqGrid('setGridWidth', gw);
});

$("#btnCopy").click(function () {
    var allRowsInGrid = $(window.paramFromView.GridId).jqGrid('getRowData');
    var t = 1;

    for (i = 1; i < allRowsInGrid.length + 1 ; i++) {
        var At = "#T";
        var At1 = "#T";
        var At2 = "#T";
        var At3 = "#T";
        At = At + 1 + "_" + i;
        At1 = At1 + 3 + "_" + i;
        At2 = At2 + 2 + "_" + i;
        At3 = At3 + 4 + "_" + i;
        if ($('#rdlBillable').is(":checked")) {
            $(At1).val($(At).val());
        }
        if ($('#rdlNonBillable').is(":checked")) {
            $(At3).val($(At2).val());
        }
    }
});
$("#btnUpdate").click(function () {
    var employeeResult = [];
    var Pid = $("#ddlProject").val();
    var weekNumber = $("#ddlWeek").val();
    var yearNumber = $("#ddlYear").val();
    var k = 1;
    var rows = $(window.paramFromView.GridId).jqGrid('getRowData');
    var j = 1;
    var m = 0;
    $.each(rows, function (index, value) {
        var rowData = value;
        if ($('#rdlBillable').is(":checked")) {
            var nBillable = $("#T" + 3 + "_" + j).val();
        }
        else
            var nBillable = null;
        if ($('#rdlNonBillable').is(":checked")) {
            var nNonBillable = $("#T" + 4 + "_" + j).val();
        }
        else
            var nNonBillable = null;
        var iHour = $("#T" + 5 + "_" + j).val();
        var empId = $("#T" + 6 + "_" + j).val();
        var Id = $("#T" + 7 + "_" + j).val();
        var Status = false;
        var d = new Date();
        var Year = yearNumber;
        j++;
        if ($('#rdlBillable').is(":checked")) {
            if (nBillable != "" && nBillable != 0) {
                employeeResult.push({ ProjectId: Pid, Emp_Id: empId, CurrentBillable: nBillable, NextNonBillable: nNonBillable, InvoiceHours: iHour, Id: Id, Status: Status, WeekNumber: weekNumber, Year: Year });
            }
        }
        if ($('#rdlNonBillable').is(":checked")) {
            if (nNonBillable != "" && nNonBillable != 0) {
                employeeResult.push({ ProjectId: Pid, Emp_Id: empId, NextBillable: nBillable, CurrentNonBillable: nNonBillable, InvoiceHours: iHour, Id: Id, Status: Status, WeekNumber: weekNumber, Year: Year });
            }
        }
        if (nBillable == "" && nNonBillable == "") {
            m++;
        }
    });

    if (employeeResult.length != m) {
        $.ajax({
            type: 'POST',
            url: '/Home/InsertData',
            data: { employeeViewModel: employeeResult },
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
                alert('Record saved successfully')
            }

        });
    }
    else {
        alert("Week " + (parseInt($("#ddlWeek").val())) + " is empty !!!");
    }
});
$("#btnSubmit").click(function () {
    debugger;
    var employeeResult = [];
    var Pid = $("#ddlProject").val();
    var weekNumber = $("#ddlWeek").val();
    var yearNumber = $("#ddlYear").val();
    var k = 1;
    var rows = $(window.paramFromView.GridId).jqGrid('getRowData');
    var j = 1;
    var m = 0;
    $.each(rows, function (index, value) {
        var rowData = value;
        if ($('#rdlBillable').is(":checked")) {
            var nBillable = $("#T" + 3 + "_" + j).val();
        }
        else
            var nBillable = null;
        if ($('#rdlNonBillable').is(":checked")) {
            var nNonBillable = $("#T" + 4 + "_" + j).val();
        }
        else
            var nNonBillable = null;
        var iHour = $("#T" + 5 + "_" + j).val();
        var empId = $("#T" + 6 + "_" + j).val();
        var Id = $("#T" + 7 + "_" + j).val();
        var Status = true;
        var d = new Date();
        var Year = yearNumber;
        j++;
        if ($('#rdlBillable').is(":checked")) {
            if (nBillable != "" && nBillable != 0) {
                employeeResult.push({ ProjectId: Pid, Emp_Id: empId, CurrentBillable: nBillable, NextNonBillable: nNonBillable, InvoiceHours: iHour, Id: Id, Status: Status, WeekNumber: weekNumber, Year: Year });
            }
        }
        if ($('#rdlNonBillable').is(":checked")) {
            if (nNonBillable != "" && nNonBillable != 0) {
                employeeResult.push({ ProjectId: Pid, Emp_Id: empId, NextBillable: nBillable, CurrentNonBillable: nNonBillable, InvoiceHours: iHour, Id: Id, Status: Status, WeekNumber: weekNumber, Year: Year });
            }
        }
        if (nBillable == "" && nNonBillable == "") {
            m++;
        }

    });
    if (employeeResult.length != m) {
        $.ajax({
            type: 'POST',
            url: '/Home/InsertData',
            data: { employeeViewModel: employeeResult },
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
                // getdata();
                alert('Record submitted succesfully');
            }
        });
    }
    else {
        alert("Week " + (parseInt($("#ddlWeek").val())) + " is empty !!!");
    }
    getdata();
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
        colNames: ['Id', 'Employee Id', 'Name', 'Designation', 'Billable', 'Non Billable', 'Billable', 'Non Billable', 'Invoice Hours'],
        colModel: [
             { name: 'Id', index: 'Id', width: 100, align: 'left' },
          { name: 'Emp_Id', index: 'Emp_Id', width: 100, align: 'left' },
          { name: 'EmployeeName', index: 'EmployeeName', width: 200, align: 'left' },
          { name: 'DesignationName', index: 'DesignationName', width: 200, align: 'left' },
          { name: 'CurrentBillable', index: 'CurrentBillable', width: 100, align: 'left' },
          { name: 'CurrentNonBillable', index: 'CurrentNonBillable', width: 100, align: 'left' },
          { name: 'NextBillable', index: 'NextBillable', width: 100, align: 'left' },
          { name: 'NextNonBillable', index: 'NextNonBillable', width: 100, align: 'left' },
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

        //multiselect: true,
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
        postData: { 'projectId': prjId, 'weekNumber': weekNumber, 'Year': year },
        data: {},
        emptyDataText: window.paramFromView.DataNotAvaliable,
        caption: 'Resource Allocation',
       // gridComplete: checkStatus(),
    });
    jQuery(window.paramFromView.GridId).jqGrid('setGroupHeaders', {
        useColSpanStyle: true,
        groupHeaders: [
          { startColumnName: 'CurrentBillable', numberOfColumns: 2, titleText: 'Week :' + $('#ddlWeek').val() },
        //  { startColumnName: 'NextBillable', numberOfColumns: 2, titleText: 'Week :' + (((parseInt($('#ddlWeek').val())) == 52) ? 1 : (parseInt($('#ddlWeek').val()) + 1)) }
          { startColumnName: 'NextBillable', numberOfColumns: 2, titleText: 'Week :' }
        ]
    });
};

//function checkStatus()
//{
//    $.ajax({
//        type: 'POST',
//        url: '/Home/hideANDshow',
//        data: { 'projectId': $("#ddlProject").val(), 'weekNumber': $('#ddlWeek').val(), 'year': $('#ddlYear').val() },
//        success: function (response) {
//            alert('!!!');
//            if (response == "True") {
//                var j= 1;
//                $.each(rows, function (index, value) {
//                    $("#T" + 3 + "_" + j).attr("disabled", "disabled");
//                    j++;
//                })
//            }
//            else
//            {}
//        },
//        error: function (response) {
//            alert("Please select project !!!");
//        }
//    })

//}

function getdata() {
    $.ajax({
        type: 'POST',
        url: '/Home/hideANDshow',
        data: { 'projectId': $("#ddlProject").val(), 'weekNumber': $('#ddlWeek').val(), 'year': $('#ddlYear').val() },
        success: function (response) {
            debugger;
            if (response == "True") {
                $('#btnCopy').hide();
                $('#btnUpdate').hide();
                $('#btnSubmit').hide();
                $(window.paramFromView.GridId).jqGrid('setColProp', 'NextBillable', { editable: false });
                $(window.paramFromView.GridId).jqGrid('setColProp', 'NextNonBillable', { editable: false });
                $(window.paramFromView.GridId).jqGrid('setColProp', 'CurrentBillable', { editable: false });
                $(window.paramFromView.GridId).jqGrid('setColProp', 'CurrentNonBillable', { editable: false });




                var rows = $(window.paramFromView.GridId).jqGrid('getRowData');
                $.each(rows, function (index, value) {
                    var cm = $(window.paramFromView.GridId).jqGrid('getColProp', 'NextBillable');
                    var m = $(window.paramFromView.GridId).jqGrid('getColProp', $("#T" + 3 + "_" + j));
                    if (response == "True") {
                        cm.editable = false;// Not Editable
                        m.editable = false;
                        $("#T" + 3 + "_" + j).attr("disabled", "disabled");

                    } else {
                        cm.editable = true;// Editable
                    }
                    j++;
                })
            }
            if (response == "False") {
                $('#btnCopy').show();
                $('#btnUpdate').show();
                $('#btnSubmit').show();
            }
            var gw = $(window.paramFromView.GridId).jqGrid('getGridParam', 'width');
            if ($('#rdlBillable').is(":checked")) {
                $(window.paramFromView.GridId).hideCol("CurrentNonBillable");
                $(window.paramFromView.GridId).hideCol("NextNonBillable");
                $(window.paramFromView.GridId).showCol("CurrentBillable");
                $(window.paramFromView.GridId).showCol("NextBillable");
            }

            if ($('#rdlNonBillable').is(":checked")) {
                $(window.paramFromView.GridId).showCol("CurrentNonBillable");
                $(window.paramFromView.GridId).showCol("NextNonBillable");
                $(window.paramFromView.GridId).hideCol("CurrentBillable");
                $(window.paramFromView.GridId).hideCol("NextBillable");
            }
            $(window.paramFromView.GridId).jqGrid('setGridWidth', gw);
        },
        error: function (response) {
            alert("Please select project !!!");
        }

    });
    $(window.paramFromView.GridId).clearGridData();
    $(window.paramFromView.GridId).jqGrid("setGridParam", { postData: { 'projectId': $("#ddlProject").val(), 'weekNumber': $('#ddlWeek').val(), 'Year': $('#ddlYear').val() }, datatype: "json" }).trigger("reloadGrid");
    jQuery(window.paramFromView.GridId).jqGrid('destroyGroupHeader');
    jQuery(window.paramFromView.GridId).jqGrid('setGroupHeaders', {
        useColSpanStyle: true,
        groupHeaders: [
          { startColumnName: 'CurrentBillable', numberOfColumns: 2, titleText: 'Week :' + (parseInt($('#ddlWeek').val()) - 1) },
          { startColumnName: 'NextBillable', numberOfColumns: 2, titleText: 'Week :' + (((parseInt($('#ddlWeek').val())) == 52) ? 1 : (parseInt($('#ddlWeek').val()))) }]
        //{ startColumnName: 'NextBillable', numberOfColumns: 2, titleText: 'Week :' + ((parseInt($('#ddlWeek').val()) + 1) == NaN) ? '' : ((parseInt($('#ddlWeek').val()) + 1)) }]
    });

    if (!$('#btnCopy').is(":visible")) {

        var rows = $(window.paramFromView.GridId).jqGrid('getRowData');
        // alert(rows);
        var j = 1;
        $.each(rows, function (index, value) {
            var rowData = value;

            $("#T" + 3 + "_" + j).attr("disabled", "disabled");

            $("#T" + 4 + "_" + j).attr("disabled", "disabled");
            j++;
        })
    }

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
            //  ProjectIsBillable();
        }
    });
}


function ProjectIsBillable() {
    $(window.paramFromView.GridId).clearGridData();
    //$('#ddlYear').empty();
    //$('#ddlYear').change(function () {
    $('#ddlYear').prop('selectedIndex', 0);
    $('#ddlWeek').empty();
    $('#ddlWeek').append($('<option></option>').val('0').html('----Select Week----'));
    //});
    var Pid = $('#ddlProject').val();
    $.ajax({
        url: '/Home/ProjectStatus',
        type: "GET",
        dataType: "JSON",
        data: { Pid: Pid },
        success: function (status) {
            // alert(status);
            if (status) {
                // $("#rdlPhaseModule").checked(true);
                //$('#rdlPhaseModule')[0].checked = true;
                //$('#rdlPhaseModule')[1].checked = false;

                $("#rdlBillable").prop('checked', true);
                $("#rdlNonBillable").prop('checked', false);
            }
            if (!status) {

                $("#rdlBillable").prop('checked', false);
                $("#rdlNonBillable").prop('checked', true);
                //$('#rdlPhaseModule')[0].checked = false;
                //$('#rdlPhaseModule')[1].checked = true;
            }
            var gw = $(window.paramFromView.GridId).jqGrid('getGridParam', 'width');
            if ($('#rdlBillable').is(":checked")) {
                $(window.paramFromView.GridId).hideCol("CurrentNonBillable");
                $(window.paramFromView.GridId).hideCol("NextNonBillable");
                $(window.paramFromView.GridId).showCol("CurrentBillable");
                $(window.paramFromView.GridId).showCol("NextBillable");
            }
            if ($('#rdlNonBillable').is(":checked")) {
                $(window.paramFromView.GridId).showCol("CurrentNonBillable");
                $(window.paramFromView.GridId).showCol("NextNonBillable");
                $(window.paramFromView.GridId).hideCol("CurrentBillable");
                $(window.paramFromView.GridId).hideCol("NextBillable");
            }
            $(window.paramFromView.GridId).jqGrid('setGridWidth', gw);
        }
    });
}