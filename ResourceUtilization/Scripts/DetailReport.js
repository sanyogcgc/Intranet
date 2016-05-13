$(document).ready(function () {
    $("#exprt").hide();
    ShowGrid();
    $(window.paramFromView.GridId).jqGrid("setLabel", "rn", "SNo.");
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
        colNames: ['Employee Id', 'Resource Name', 'Designation', 'Manager Name', 'Planned', 'Actual', 'Invoiced'],
        colModel: [
              { name: 'Emp_Id', index: 'Emp_Id', width: 100, align: 'left', hidden: true },
              { name: 'EmployeeName', index: 'EmployeeName', width: 200, align: 'left' },
              { name: 'DesignationName', index: 'DesignationName', width: 200, align: 'left' },
              { name: 'ManagerName', index: 'ManagerName', width: 200, align: 'left' },
              { name: 'Planned', index: 'Planned', width: 100, formatter: 'number' },
              { name: 'Actual', index: 'Actual', width: 100, formatter: 'number' },
              { name: 'Invoiced', index: 'Invoiced', width: 100, formatter: 'number' }
        ],
        hidegrid: false,
        sortname: 'EmployeeName',
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
        postData: {},
        data: {},
        emptyDataText: window.paramFromView.DataNotAvaliable,
        caption: 'Planned Vs Actual Vs Invoiced',
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



function getData() {
    var prjId = $('#ddlProject').val();
    var weekNumber = $('#ddlWeek').val();
    var year = $('#ddlYear').val();

    $(window.paramFromView.GridId).clearGridData();
    $(window.paramFromView.GridId).jqGrid("setGridParam", { postData: { 'projectId': prjId == "" ? 0 : prjId, 'weekNumber': weekNumber == "" ? 0 : weekNumber, 'year': year == "" ? 0 : year }, datatype: "json" }).trigger("reloadGrid");

}

function fillWeek() {
    var year = $('#ddlYear').val();
    $.ajax({
        url: '/Home/fillWeek',
        type: "GET",
        dataType: "JSON",
        data: { year: year },
        success: function (years) {
            $("#ddlWeek").html(""); // clear before appending new list 
            $.each(years, function (i, year) {
                $("#ddlWeek").append(
                    $('<option></option>').val(year.Value).html(year.Text));
            });
        }
    });
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

function ResetData()
{
    $(window.paramFromView.GridId).clearGridData();
    $('#ddlYear').prop('selectedIndex', 0);
    $('#ddlWeek').empty();
    $('#ddlWeek').append($('<option></option>').val('0').html('----Select Week----'));
}