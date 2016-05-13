$(document).ready(function () {
    $('.ProjectDiv').hide();
    $('#exprt').hide();
    var $radios = $('input[name=RadioBtn]').change(function () {
        $(window.paramFromView.GridId).clearGridData();
        $('#ddlYear').prop('selectedIndex', 0);
        $('#ddlWeek').empty();
        $('#ddlWeek').append($('<option></option>').val('0').html('----Select Week----'));
        var value = $radios.filter(':checked').val();
        //alert(value);
        //debugger;
        //if (value == "DirectReportee") {
        //    $('.ProjectDiv').hide();
        //    $(window.paramFromView.GridId).clearGridData();
        //}
        //else {
        //    $('.ProjectDiv').show();
        //    $(window.paramFromView.GridId).clearGridData();
        //    // $("#gview__ResourcePlanningGrid").jqGrid("clearGridData", true).trigger("reloadGrid");
        //}
    });

    ShowGrid();
    $(window.paramFromView.GridId).jqGrid("setLabel", "rn", "SNo.");
});

function ShowGrid() {
    var prjId = $('#ddlProject').val();
    var weekNumber = $('#ddlWeek').val();
    var year = $('#ddlYear').val();

    $(window.paramFromView.GridId).jqGrid({
        loadError: function (xhr, status, error) {
            $('.exprt').hide();
            alert('load error: ' + error);
        },
        datatype: 'json',
        colNames: ['Employee Id', 'Resource Name', 'Designation', 'Manager Name', 'Planned', 'Utilization', 'Availability'],
        colModel: [
              { name: 'Emp_Id', index: 'Emp_Id', width: 100, align: 'left', hidden: true },
              { name: 'EmployeeName', index: 'EmployeeName', width: 200, align: 'left' },
              { name: 'DesignationName', index: 'DesignationName', width: 200, align: 'left' },
              { name: 'ManagerName', index: 'ManagerName', width: 200, align: 'left' },
              { name: 'PlannedHours', index: 'PlannedHours', width: 100, align: 'left' },
              { name: 'Utilization', index: 'Utilization', width: 100 },
               { name: 'Availability', index: 'Availability', width: 100 },
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
        caption: 'Resource Planning',
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
    $('.exprt').show();
    var prjId;// = $('#ddlProject').val();
    var weekNumber = $('#ddlWeek').val();
    var year = $('#ddlYear').val();
    var value = $("input[name=RadioBtn]:checked").val()
  // var $radios = $('input[name=RadioBtn]').change(function () {
       // var value = $radios.filter(':checked').val();
        if (value == "DirectReportee") {
            $('#ddlProject').empty();
            prjId = 0;
        }
        if (value == "InDirectReportee") {
            $('#ddlProject').empty();
            prjId = 1;
        }
        if (value == "All") {
            $('#ddlProject').empty();
            prjId = 2;
        }
       
 //  });
    $(window.paramFromView.GridId).clearGridData();
    $(window.paramFromView.GridId).jqGrid("setGridParam",
        {
            postData: { 'projectId': prjId == "" ? 0 : prjId, 'weekNumber': weekNumber == "" ? 0 : weekNumber, 'year': year == "" ? 0 : year },
            datatype: "json"
        })
        .trigger("reloadGrid");

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

function onSelectProject() {
    //var project = $('#ddlProject').val();
    $.ajax({
        url: '/Report/GetProject',
        type: "GET",
        dataType: "JSON",
        //data: { year: year },
        success: function (projectlist) {
            var list = projectlist.ProjectList;
            $("#ddlProject").html(""); // clear before appending new list 
            $.each(list, function (i, project) {
                $("#ddlProject").append(
                    $('<option></option>').val(project.ID).html(project.ClientProject));
                $(window.paramFromView.GridId).clearGridData();
                //$("#ddlWeek option:selected").remove();
                //$('<option></option>').val(project.value).html(project.Text));
            });
        }
    });
}

$('#btnExportReport').click(function () {
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
