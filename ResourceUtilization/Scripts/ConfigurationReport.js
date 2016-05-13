$(document).ready(function () {
    ShowGrid();
    $(window.paramFromView.GridId).hideCol("Id");
    $('#exprt').hide();
    $(window.paramFromView.GridId).jqGrid("setLabel", "rn", "SNo.");
   
    //$("#ddlStartDate").datepicker({
    //   // numberOfMonths: 2,
    //    onSelect: function (selected) {
    //        $("#ddlEndDate").datepicker("option", "minDate", selected)
    //    }
    //});
    //$("#ddlEndDate").datepicker({
    //  //  numberOfMonths: 2,
    //    onSelect: function (selected) {
    //        $("#ddlStartDate").datepicker("option", "maxDate", selected)
    //    }
    //});
});


function ShowGrid() {

    //if ($('#ddlStartDate').val().length > 0) {
    var  FromDate = new Date($('#ddlStartDate').val()).toDateString("MM/dd/yyyy");
    //}
    //else {
    //    alert('Please enter From date');
    //    return false;
    //}
    //if ($('#ddlEndDate').val().length > 0) {
     
    var Todate = new Date($('#ddlEndDate').val()).toDateString("MM/dd/yyyy")
    //else {
    //    alert('Please enter To date');
    //    return false;
    //}
    if (FromDate > Todate)
    {
        alert('From Date cannnot be greater than To date')
        return false;
    }
    if ($('#technologygrp').val() == "") {
        var RscId = 0;
    }
    else {
        var RscId = $('#technologygrp').val();
    }

    var RourceId = $("#resources").val();
    if (typeof RourceId == "undefined" || RourceId == 0)
        RourceId = 0;

    $(window.paramFromView.GridId).jqGrid({
        loadError: function (xhr, status, error) {
            alert('load error: ' + error);
        },
        datatype: 'json',
        colNames: ['EmpID', 'Resource', 'Manager Name', 'EndDate', 'Allocation[%]', 'Technology'],
        colModel: [
          { name: 'EmpID', index: 'EmpID', width: 100, align: 'left' },
          { name: 'empName', index: 'empName', width: 100, align: 'left' },
          { name: 'ManagerName', index: 'ManagerName', width: 100, align: 'left' },
          { name: 'EndTime', index: 'EndDate', width: 100, align: 'left', formatter: 'date', formatoptions: { srcformat: 'd/m/Y', newformat: 'd/m/Y' } },
          { name: 'Allocation', index: 'Allocation', width: 100, align: 'left', formatter: 'number', formatoptions: { decimalPlaces: 2 } },
          { name: 'Technology_Name', index: 'Technology_Name', width: 100, align: 'left' },
        ],


        hidegrid: false,
        sortname: 'ProjName',
        sortorder: "asc",
        datatype: 'json',
        viewrecords: true,
        gridview: true,
        mtype: 'POST',
        rownumbers: true,
        rownumWidth: 35,
        subGrid: true,
        //multiselect: true,
        rowNum: -1,
        jsonReader: {
            root: "rows",
            Id: "EmpID",
            page: "page",
            total: "total",
            records: "records",
            repeatitems: false,
            userdata: "userdata",

        },
        subGridBeforeExpand: function (divid, rowid) {
            // #grid is the id of the grid
            var expanded = jQuery("td.sgexpanded", window.paramFromView.GridId)[0];
            if (expanded) {
                setTimeout(function () {
                    $(expanded).trigger("click");
                }, 100);
            }
        },
        subGridRowExpanded: function (subgrid_id, row_id) {
            if ($('#resources').val() > 0)
                var RscId = $('#resources').val();
            else {
                debugger
                var RscId = $(window.paramFromView.GridId).jqGrid('getCell', row_id, 'EmpID')
            }
            var FromDate = new Date($('#ddlStartDate').val()).toDateString("MM/dd/yyyy");
            var Todate = new Date($('#ddlEndDate').val()).toDateString("MM/dd/yyyy")
            var subgrid_table_id;
            subgrid_table_id = subgrid_id + "_t";
            jQuery("#" + subgrid_id).html("<table id='" + subgrid_table_id + "' class='scroll'></table>");
            jQuery("#" + subgrid_table_id).jqGrid({
                // url:"subgrid.php?q=2&id="+row_id,
                url: '/ReportConfiguration/getdata',
                mtype: 'POST',
                datatype: 'json',
                postData: { 'RscId': RscId, 'Todate': Todate, 'FromDate': FromDate },
                colNames: ['Id', 'Project', 'Start date', 'End Date', 'Allocation %'],//, 'Action'
                colModel: [
                  { name: "Id", index: "Id", width: 100, align: 'left', key: true },
                  { name: "ProjName", index: "ProjName", width: 100, align: 'left', key: true },
                  { name: "StartDate", index: "StartDate", width: 150, align: 'left', formatter: 'date', formatoptions: { srcformat: 'd/m/Y', newformat: 'd/m/Y' } },
                  { name: "EndTime", index: "EndTime", width: 150, align: 'left', formatter: 'date', formatoptions: { srcformat: 'd/m/Y', newformat: 'd/m/Y' } },
                  { name: "Allocation", index: "Allocation", width: 100, align: "left", formatter: 'number', formatoptions: { decimalPlaces: 2 } },
                  //{
                  //    name: 'act', index: 'act', width: 90, sortable: false, formatter: displayButtons,
                  //    formatter: function (cellvalue, options, rowObject) {

                  //        var data = rowObject;
                  //        return "<input type='button' value='Edit' onclick='EditData(" + rowObject.Id + ")'\>";
                  //    }
                  //},
                ],
                height: '100%',
                rowNum: 20,
                sortname: 'Id',
                sortorder: "asc",
                onSelectRow: function (rowId) {
                    alert('rowsel');
                    $("#" + subgrid_table_id).jqGrid('toggleSubGridRow', rowId);
                },

            });
        },

        url: window.paramFromView.Url,
        postData: { 'RscId': RscId, 'RourceId': RourceId ,'Todate': Todate, 'FromDate': FromDate},
        data: {},
        emptyDataText: window.paramFromView.DataNotAvaliable,
        caption: 'Resource Configuration',
        gridComplete: function () {
            var recs = parseInt($(window.paramFromView.GridId).getGridParam("records"), 10);
            if (isNaN(recs) || recs == 0) {
                $("#exprt").hide();
            }
            else {
                $('#exprt').show();

            }
        }

    });


};

function GetResourcesFromTechnologyGrp() {
    $('.displayError').css('visibility', 'hidden');
    if ($('#Table1st').length > 0) {
        $('#Table1st').remove();
    }
    var Tech_id = parseInt($('#technologygrp').val());
    if (isNaN(Tech_id) || Tech_id == 0) {
        Tech_id = 0;
        $('#resources').empty();
        $('#resources').append($('<option></option>').val('0').html('----Select----'));
        $('.displayError').css('visibility', 'visible');
        $('#Table1st').remove();
        // ShowGrid();
        return false;
    }
    getdataAll();
    $.ajax({
        type: 'Get',
        url: '/ResourceConfiguration/GetEmployeeList',
        data: { Technology_id: Tech_id },
        datatype: 'JSON',
        success: function (response) {
            $('#resources').empty();
            $('#resources').append($('<option></option>').val('0').html('----Select----'));
            $.each(response, function (i, data) {
                $('#resources').append($('<option></option>').val(data.Emp_Id).html(data.EmpName));
            });
        },
        error: function (response) {
            $('#resources').empty();
            $('#resources').append($('<option></option>').val('0').html('----Select----'));
        }
    });
    ShowDetails();
    $('#gridDetail').clearGridData();
    $('#gridDetail').jqGrid("setGridParam", { postData: { 'RscId': $("#technologygrp").val(), 'RourceId': $("#resources").val(), 'Todate': new Date($('#ddlEndDate').val()).toDateString("MM/dd/yyyy"), 'FromDate': new Date($('#ddlStartDate').val()).toDateString("MM/dd/yyyy") }, datatype: "json", url: '/ReportConfiguration/GetDataDetails' }).trigger("reloadGrid");
    $('#gridDetail').jqGrid("setLabel", "rn", "SNo.");
    return true;
}

function getdataAll() {
    if($('#ddlStartDate').val().length>0)
    {
        var FromDate= $('#ddlStartDate').val();
    }
    else
    {
        alert('Please enter From date');
        return false;
    }
    if($('#ddlEndDate').val().length>0)
    {
        var Todate = $('#ddlEndDate').val();
    }
    else
    {
        alert('Please enter To date');
        return false;
    }
    if (FromDate > Todate) {
        alert('From Date cannnot be greater than To date')
        return false;
    }
    var RourceId = $("#resources").val();
    if (typeof RourceId == "undefined" || RourceId == 0)
        RourceId = 0;
    $.ajax({
        type: 'POST',
        url: '/ReportConfiguration/GetDataAll',
        data: { 'RscId': $("#technologygrp").val(), 'RourceId': RourceId },
        success: function (response) {

        },
        error: function (response) {
            alert(response);
        }
    });
    $(window.paramFromView.GridId).clearGridData();
    $(window.paramFromView.GridId).jqGrid("setGridParam", { postData: { 'RscId': $("#technologygrp").val(), 'RourceId': RourceId, 'Todate': Todate, 'FromDate': FromDate }, datatype: "json" }).trigger("reloadGrid");
}


function displayButtons(cellvalue, options, rowObject) {
    var da = $(window.paramFromView.GridId).jqGrid('getGridParam', "selrow");
    var edit = '<button onclick="getSelectedRow(); return false;" id="btnEdit"  >Select</button>';
    return edit;//+ save + restore;
}


function exportGrid() {
    mya = $(window.paramFromView.GridId).getDataIDs(); // Get All IDs
    var data = $(window.paramFromView.GridId).getRowData(mya[0]); // Get First row to get the
    // labels
    var colNames = new Array();
    var ii = 0;
    for (var i in data) {
        colNames[ii++] = i;
    } // capture col names

    var html = "<html><head>"
            + "<style script=&quot;css/text&quot;>"
            + "table.tableList_1 th {border:1px solid black; text-align:center; "
            + "vertical-align: middle; padding:5px;}"
            + "table.tableList_1 td {border:1px solid black; text-align: left; vertical-align: top; padding:5px;}"
            + "</style>"
            + "</head>"
            + "<body style=&quot;page:land;&quot;>";


    for (var k = 0; k < colNames.length; k++) {
        html = html + "<th>" + colNames[k] + "</th>";
    }
    html = html + "</tr>"; // Output header with end of line
    for (i = 0; i < mya.length; i++) {
        html = html + "<tr>";
        data = $(window.paramFromView.GridId).getRowData(mya[i]); // get each row
        for (var j = 0; j < colNames.length; j++) {
            html = html + "<td>" + data[colNames[j]] + "</td>"; // output each Row as
            // tab delimited
        }
        html = html + "</tr>"; // output each row with end of line
    }
    html = html + "</table></body></html>"; // end of line at the end
    alert(html);
    html = html.replace(/'/g, '&apos;');
    var form = "<form name='pdfexportform' action='generategrid' method='post'>";
    form = form + "<input type='hidden' name='pdfBuffer' value='" + html + "'>";
    form = form + "</form><script>document.pdfexportform.submit();</sc"
        + "ript>";
    OpenWindow = window.open('', '');
    OpenWindow.document.write(form);
    OpenWindow.document.close();
}

$('#btnExportReport').click(function () {
    debugger;
    $(function () {
        $(".table2excel").table2excel({
            //$("#gview__ResourcePlanningGrid").table2excel({               
            exclude: ".noExl",
            name: "Resource",
            filename: "Report",
            fileext: ".xls",
            exclude_img: true,
            exclude_links: true,
            exclude_inputs: true
        });
    });


});

function Export()
{
    $(window.paramFromView.GridId).jqGrid().trigger('reloadGrid', [{ page: 1 }]);
  
  
      //  setTimeout(
      //function () {
      //    $("#jqGrid").addClass("table2excel");
      //}, 10000);

    $(".table2excel").table2excel({
        //$("#gview__ResourcePlanningGrid").table2excel({               
        exclude: ".noExl",
        name: "Resource",
        filename: "Report",
        fileext: ".xls",
        exclude_img: true,
        exclude_links: true,
        exclude_inputs: true
    });

   // $("#jqGrid").removeClass("table2excel");
}



function ShowDetails() {
    debugger;
    var FromDate = new Date($('#ddlStartDate').val()).toDateString("MM/dd/yyyy");

    var Todate = new Date($('#ddlEndDate').val()).toDateString("MM/dd/yyyy");

    if ($('#technologygrp').val() == "") {
        var RscId = 0;
    }
    else {
        var RscId = $('#technologygrp').val();
    }

    var RourceId = $("#resources").val();
    if (typeof RourceId == "undefined" || RourceId == 0)
        RourceId = 0;

    $('#gridDetail').jqGrid({
        loadError: function (xhr, status, error) {
            alert('load error: ' + error);
        },
      
        colNames: ['Name', 'Project', 'Start date', 'End Date', 'Allocation %'],
        colModel: [
                   { name: "empName", index: "empName", width: 100, align: 'left', key: true },
                   { name: "ProjName", index: "ProjName", width: 100, align: 'left', key: true },
                   { name: "StartDate", index: "StartDate", width: 150, align: 'left', formatter: 'date', formatoptions: { srcformat: 'd/m/Y', newformat: 'd/m/Y' } },
                   { name: "EndTime", index: "EndTime", width: 150, align: 'left', formatter: 'date', formatoptions: { srcformat: 'd/m/Y', newformat: 'd/m/Y' } },
                   { name: "Allocation", index: "Allocation", width: 100, align: "left", formatter: 'number', formatoptions: { decimalPlaces: 2 } },
        ],
        hidegrid: true,
        sortname: 'empName',
        sortorder: "asc",
       
        viewrecords: true,
        gridview: true,
        url: '/ReportConfiguration/GetDataDetails',
        mtype: 'POST',
        datatype: 'json',
        rownumbers: true,
        rownumWidth: 35,
        //multiselect: true,
        rowNum: -1,
        jsonReader: {
            root: "rows",
            Id: "empName",
            page: "page",
            total: "total",
            records: "records",
            repeatitems: false,
            userdata: "userdata",

        },
     //   url: window.paramFromView.Url,
        postData: { 'RscId': RscId, 'Todate': Todate, 'FromDate': FromDate, 'RourceId': RourceId },
        data: {},
        //emptyDataText: window.paramFromView.DataNotAvaliable,
        caption: 'Resource Configuration',

    });
};


$("#ddlStartDate").click(function () {
    $('#technologygrp').prop('selectedIndex', 0);
});

$("#ddlEndDate").click(function () {
    $('#technologygrp').prop('selectedIndex', 0);
});


function ExportExcel() {
    debugger;
    var dtltbl = $('#_ResourceGrid').html();
    window.open('data:application/vnd.ms-excel,' + $('#_ResourceGrid').html());
}


