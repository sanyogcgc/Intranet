$(document).ready(function () {
    ShowGrid();

    $(window.paramFromView.GridId).hideCol("Id");
    $(window.paramFromView.GridId).jqGrid("setLabel", "rn", "SNo.");
});

function AddNewProjectDetails(idVal) {

    try {
        if ($('#Table1st').length > 0) {
            $('#Table1st').remove();
        }
        $('.displayError').css('visibility', 'hidden');
        var Tech_id = parseInt($('#technologygrp').val());
        if (isNaN(Tech_id) || Tech_id == 0) {
            Tech_id = 0;
            $('#resources').empty();
            $('#resources').append($('<option></option>').val('0').html('----Select----'));
            $('.displayError').css('visibility', 'visible');
            // ShowGrid();
            alert('Please select Technology group and Resource');
            return false;
        }
       // idVal = parseInt($('#resources').val());
        if (isNaN(Tech_id) || Tech_id == 0) {
            $('#resourcesError').css('visibility', 'visible')
            return false;
        }
        $.ajax({
            url: '/ResourceConfiguration/AddNewProjectConfigToResource',
            type: 'Get',
            data: { isEdit: idVal, TechId: Tech_id },
            success: function (response) {
                $('#DivHead').append(response);
                $("#datepicker1").datepicker();
                $("#ddlStartDate").datepicker();
                $("#ddlEndDate").datepicker();
                $("#resourcesEdit").val($('#resources').val());
              
              
            },
            error: function (error) {
                alert('Error in Loading...');
            }
        });
    }
    catch (e) {
        alert(e);
    }
}

function AddNewProjectDetails1(idVal) {
    debugger;
    try {
        if ($('#Table1st').length > 0) {
            $('#Table1st').remove();
        }
        $('.displayError').css('visibility', 'hidden');
        var Tech_id = parseInt($('#technologygrp').val());
        if (isNaN(Tech_id) || Tech_id == 0) {
            Tech_id = 0;
            $('#resources').empty();
            $('#resources').append($('<option></option>').val('0').html('----Select----'));
            $('.displayError').css('visibility', 'visible');
            // ShowGrid();
            alert('Please select Technology group and Resource');
            return false;
        }
        var TechId = $('#technologygrp').val();
        //Tech_id = parseInt($('#resources').val());
        //if (isNaN(Tech_id) || Tech_id == 0) {
        //    $('#resourcesError').css('visibility', 'visible')
        //    return false;
        //}
        $.ajax({
            url: '/ResourceConfiguration/AddNewProjectConfigToResource',
            type: 'Get',
            data: { isEdit: idVal, TechId: TechId },
            success: function (response) {
                $('#DivHead').append(response);
                $("#datepicker1").datepicker();
                $("#ddlStartDate").datepicker();
                $("#ddlEndDate").datepicker();
                $("#resourcesEdit").prop("disabled", true);
               
            },
            error: function (error) {
                alert('Error in Loading...');
            }
        });
    }
    catch (e) {
        alert(e);
    }
}

function SaveResourceConfig() {
    try {
        var ResourceConfigurationData = [];
        $('.requiredata').css('visibility', 'hidden');
        $('.displayError').css('visibility', 'hidden');
        var Tech_id = parseInt($('#technologygrp').val());
        if (isNaN(Tech_id) || Tech_id == 0) {
            Tech_id = 0;
            $('#resources').empty();
            $('#resources').append($('<option></option>').val('0').html('----Select----'));
            $('.displayError').css('visibility', 'visible');
            // ShowGrid();
            return false;
        }
        
        //Tech_id = parseInt($('#resources').val());
        //if (isNaN(Tech_id) || Tech_id == 0) {
        //    $('#resourcesError').css('visibility', 'visible')
        //    return false;
        //}
        Tech_id = parseInt($('#resourcesEdit').val());
        if (isNaN(Tech_id) || Tech_id == 0) {
            $('#SelectedResoucre').css('visibility', 'visible')
            return false;
        }
        
        if ($('#Table1st').length == 0) {
            return false;
        }
        var _val = parseInt($('#ddlProject').val());
        if (isNaN(_val)) {
            $('#SelectedProject').css('visibility', 'visible');
            return false;
        }
        _val = $('#ddlStartDate').val();
        if (_val.length == 0) {
            $('#SelectedStrDate').css('visibility', 'visible');
            return false;
        }
        _val = $('#ddlEndDate').val();
        if (_val.length == 0) {
            $('#ddlEndDate').css('visibility', 'visible');
            return false;
        }

        _val = $('#ddlAllocation').val();
        if (isNaN(_val) || _val <= 0 || _val > 100) {
            $('#SelectedAllocation').css('visibility', 'visible');
            return false;
        }

        _val = $('#hdnID').val();
        if (isNaN(!_val) || _val > 0) {
            var id = _val;
        }
        else {
            var id = 0;
        }
        var RourceId = $("#resources").val();
        if (typeof RourceId == "undefined" || RourceId == 0)
            RourceId = 0;
        var _Date1 = Date.parse($('#ddlStartDate').val())
        var _Date2 = Date.parse($('#ddlEndDate').val())
        if (_Date1 > _Date2) {
            alert('Start date greater than End date');
            $('#SelectedStrDate').css('visibility', 'visible');
            return false;
        }

        if (confirm("Do you save resource configuration detail ????"))
        { }
        else
        { return false; }
        ResourceConfigurationData.push({ ProjectId: $('#ddlProject').val(), StartDate: new Date($('#ddlStartDate').val()).toDateString("MM/dd/yyyy"), EndTime: new Date($('#ddlEndDate').val()).toDateString("MM/dd/yyyy"), Allocation: $('#ddlAllocation').val(), EmpID: $('#resourcesEdit').val(), Id: id });
        $.ajax({
            type: 'Post',
            url: '/ResourceConfiguration/SubmitChanges',
            datatype: 'Json',
            data: { List1: ResourceConfigurationData, RscdId: $('#hdnid').val() },
            success: function (response) {
                $('#Table1st').remove();
                // ShowGrid();
                if (response == 1)
                    alert('Data Saved Successfully..!!!!');
                if (response == 2)
                    alert('Data Updated Successfully..!!!!');
                $(window.paramFromView.GridId).clearGridData();
                $(window.paramFromView.GridId).jqGrid("setGridParam", { postData: { 'RscId': $("#resources").val() ,  'RourceId': RourceId}, datatype: "json" }).trigger("reloadGrid");
                alert('data saved succesfully')
                $('#technologygrp').prop('selectedIndex', 0);
                $('#resources').prop('selectedIndex', 0);
            },
            error: function (response) {
                alert('Error');
            }

        });
    }
    catch (e)
    { alert(e); }
}

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
    return true;
}


function ShowGrid() {

    if ($('#technologygrp').val() == "") {
        var RscId = 0;
    }
    else {
        // var RscId = $('#resources').val();
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
            //  colNames: ['EmpID', 'Resource',  'Project', 'StartDate', 'EndDate', 'Allocation[%]', 'ID', 'Action'],
            colNames: ['EmpID', 'Resource',  'EndDate', 'Allocation[%]', 'ID'],
            colModel: [
              { name: 'EmpID', index: 'EmpID', width: 200, align: 'left' },
              { name: 'empName', index: 'empName', width: 200, align: 'left' },
              //{ name: 'ProjName', index: 'Project', width: 200, align: 'left' },
              //{ name: 'StartDate', index: 'StartDate', width: 200, align: 'left', formatter: 'date', formatoptions: { srcformat: 'd/m/Y', newformat: 'd/m/Y' } },
              { name: 'EndTime', index: 'EndDate', width: 200, align: 'left', formatter: 'date', formatoptions: { srcformat: 'd/m/Y', newformat: 'd/m/Y' } },
              { name: 'Allocation', index: 'Allocation', width: 100, align: 'left' ,formatter: 'number', formatoptions: { decimalPlaces: 2 } },
              { name: 'Id', index: 'CurrentNonBillable', width: 0, align: 'left' },
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
                Id: "Id",
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
                // we pass two parameters
                // subgrid_id is a id of the div tag created within a table
                // the row_id is the id of the row
                // If we want to pass additional parameters to the url we can use
                // the method getRowData(row_id) - which returns associative array in type name-value
                // here we can easy construct the following
                if ($('#resources').val() > 0)
                    var RscId = $('#resources').val();
                else {
                    debugger
                    var RscId = $(window.paramFromView.GridId).jqGrid('getCell', row_id, 'EmpID')
                }
                var subgrid_table_id;
                subgrid_table_id = subgrid_id + "_t";
                jQuery("#" + subgrid_id).html("<table id='" + subgrid_table_id + "' class='scroll'></table>");
                jQuery("#" + subgrid_table_id).jqGrid({
                    // url:"subgrid.php?q=2&id="+row_id,
                    url: '/ResourceConfiguration/getdata',
                    mtype: 'POST',
                    datatype: 'json',
                    postData: { 'RscId': RscId },
                    colNames: ['Id', 'Project', 'Start date', 'End Date', 'Allocation %', 'Action'],
                    colModel: [
                      { name: "Id", index: "Id", width: 100, align: 'left', key: true },
                      { name: "ProjName", index: "ProjName", width: 100, align: 'left', key: true },
                      { name: "StartDate", index: "StartDate", width: 150, align: 'left', formatter: 'date', formatoptions: { srcformat: 'd/m/Y', newformat: 'd/m/Y' } },
                      { name: "EndTime", index: "EndTime", width: 150, align: 'left', formatter: 'date', formatoptions: { srcformat: 'd/m/Y', newformat: 'd/m/Y' } },
                      { name: "Allocation", index: "Allocation", width: 100, align: "left", formatter: 'number', formatoptions: { decimalPlaces: 2 } },
                      {
                          name: 'act', index: 'act', width: 90, sortable: false, formatter: displayButtons,
                          formatter: function (cellvalue, options, rowObject) {

                              var data = rowObject;
                              return "<input type='button' value='Edit' onclick='EditData(" + rowObject.Id + ")'\>";
                          }
                      },
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
            postData: { 'RscId': RscId, 'RourceId': RourceId },
            data: {},
            emptyDataText: window.paramFromView.DataNotAvaliable,
            caption: 'Resource Configuration',
      
                
            //gridComplete: alert('1'),
            //$(window.paramFromView.GridId).find('input[type=button]').each(function () {
            //    alert(1);
            //    $(this).click(function(){
            //        var therowid = $(this).parents('tr:last').attr('id');
            //        $(window.paramFromView.GridId).jqGrid('setSelection', therowid);
            //        alert(therowid);
            //    });
            //}),

        });
    

};

function displayButtons(cellvalue, options, rowObject) {
    var da = $(window.paramFromView.GridId).jqGrid('getGridParam', "selrow");
    var edit = '<button onclick="getSelectedRow(); return false;" id="btnEdit"  >Select</button>';
    return edit;//+ save + restore;
}

function EditData(object1) {
  //  alert(object1);
    AddNewProjectDetails1(object1);
}

function getdata() {
    $.ajax({
        type: 'POST',
        url: '/ResourceConfiguration/GetData',
        data: { 'RscId': $("#resources").val() },
        success: function (response) {
          //  alert('!');
          //  ShowGrid();
            //   alert(1);
        },
        error: function (response) {
            //  ShowGrid();
            alert(response);
        }
    });
    $(window.paramFromView.GridId).clearGridData();
    $(window.paramFromView.GridId).jqGrid("setGridParam", { postData: { 'RscId': $("#resources").val() }, datatype: "json" }).trigger("reloadGrid");
    //jQuery(window.paramFromView.GridId).jqGrid('destroyGroupHeader');
}

function getdataAll() {
  
    var RourceId = $("#resources").val();
    if (typeof RourceId == "undefined" || RourceId== 0)
        RourceId= 0;
    $.ajax({
        type: 'POST',
        url: '/ResourceConfiguration/GetDataAll',
        data: { 'RscId': $("#technologygrp").val(), 'RourceId': RourceId},
        success: function (response) {
        
        },
        error: function (response) {
            //  ShowGrid();
            alert(response);
        }
    });
    $(window.paramFromView.GridId).clearGridData();
    $(window.paramFromView.GridId).jqGrid("setGridParam", { postData: { 'RscId': $("#technologygrp").val(), 'RourceId': RourceId }, datatype: "json" }).trigger("reloadGrid");
    //jQuery(window.paramFromView.GridId).jqGrid('destroyGroupHeader');
}

function getSelectedRow() {

    var grid = $(window.paramFromView.GridId);
    var rowKey = grid.jqGrid('getGridParam', "selrow");

    if (rowKey > 0)
        var celValue = grid.jqGrid('getCell', rowKey, 'Id');
    if (rowKey) {
        // alert("Selected row primary key is: " + rowKey);
        // alert(celValue);
        if (!isNaN(celValue) || celValue > 0) {
            AddNewProjectDetails(celValue);
        }
    }
    else
        alert("No rows are selected");
}

function clickrow() {

    $(window.paramFromView.GridId).find('input[type=button]').each(function () {
        $(this).click(function () {
            var therowid = $(this).parents('tr:last').attr('id');
            $(window.paramFromView.GridId).jqGrid('setSelection', therowid);

            //alert(therowid);
        });
    });
    getSelectedRow();
}






