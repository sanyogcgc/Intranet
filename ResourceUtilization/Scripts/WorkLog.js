$(document).ready(function () {

    onSelectProject();
    SetSerialNumber();
    //Test();
});
function ONTimeMinuteEnter(objId, ObjNextId) {
    debugger;
    try {
        $(objId).on("keydown", function (event) {
            if (event.which == 13)
            {
                $(objId).focus();
            }
        });
    }
    catch (e) {
        alert(e);
    }
}
function DeleteRow() {
    try {
        var _isChecked = false;
        if ($('#hdnRowIndexNumber').val() <= 1) { return false; }
        if ($('#hdnViewRowCreated').val() <= 0) { return false; }
        for (z = 1; z <= $('#hdnViewRowCreated').val() ; z++) {
            if ($('#chkDelete_' + z)) {
                if ($('#chkDelete_' + z).is(":checked") == true) {
                    _isChecked = true;
                    break;
                }
            }
        }
        if (_isChecked == false) {
            alert('Select row to be deleted....!!!!!');
            return false;
        }
        if (confirm('Do you want to delete row ?')) {
            //return true;
        }
        else {
            return false;
        }

        for (z = 1; z <= $('#hdnViewRowCreated').val() ; z++) {
            if ($('#chkDelete_' + z)) {
                if ($('#chkDelete_' + z).is(":checked")) {
                    var _id = $('#td_' + z).attr('id');
                    $('#' + _id).remove();
                    z = 1;
                }
            }
        }
        $('#CheckAlls').prop("checked", false);
        _isChecked = false;
        for (z = 1; z <= $('#hdnViewRowCreated').val() ; z++) {
            if ($('#chkDelete_' + z).length > 0)
            {
                _isChecked = true;
                break;
            }
        }
        if (_isChecked == false)
        {
            AddNewRow('#hdnViewRowCreated');
        }
        SetSerialNumber();
        Calculatetime();
    }
    catch (e) {
        alert(e);
    }
}

function OnkeyReturnAddRow(rowno, e) {
    debugger;
    try {
        var keycode = e.which || e.keycode;
        var _isLastRow = true;
        if (keycode != 13) {
            return false;
        }
        for (z = rowno + 1; z <= $('#hdnViewRowCreated').val() ; z++) {
            if ($('#chkDelete_' + z).length > 0) {
                _isLastRow = false;
                break;
            }
        }
        if (_isLastRow == true) {
            AddNewRow('#hdnViewRowCreated');
        }
    }
    catch (e) {
        alert(e);
    }
}

function AddNewRow(RowNext) {
    debugger;
    try {
        $('.displayError').css('visibility', 'hidden');
        if (IsEmptyRow() == false) {
            return false;
        }
        var row = parseInt($(RowNext).val());
        //if (row > 5)
        //{
        //    alert('No more rows are allowed to add.');
        //    return false;
        //}
        var rowIndex = parseInt($('#hdnRowIndexNumber').val());
        if (isNaN(rowIndex)) {
            rowIndex = 0;
        }
        if (row <= 0) {
            row = 1;
        }
        $.ajax({
            type: 'Get',
            url: '/WorkLog/AddNewRow',
            data: { increment: row, rowIndex: rowIndex + 1 },
            success: function (data) {
                $("#WorkSpace tbody").append(data);
                $(RowNext).val(row + 1);
                $('#hdnRowIndexNumber').val(rowIndex + 1);
                SetSerialNumber();
                Calculatetime();
                $('#ddlProject_' + $('#hdnViewRowCreated').val()).focus();
            }
        });
    }
    catch (e) {
        alert(e);
    }
}
function Calculatetime() {
    debugger;
    try {
        var _temptime = parseInt($('#ddlTime_1').val());
        var _tempmin = parseInt($('#ddlMinute_1').val());
        var _carry = 0;
        if (isNaN(_temptime)) { _temptime = 0; }
        if (isNaN(_tempmin)) { _tempmin = 0; }
        for (z = 2; z <= $('#hdnViewRowCreated').val() ; z++) {
            if ($('#ddlTime_' + z).length > 0) {
                if (!isNaN(parseInt($('#ddlTime_' + z).val()))) {
                    _temptime = _temptime + parseInt($('#ddlTime_' + z).val());
                }
            }
        }
        for (z = 2; z <= $('#hdnViewRowCreated').val() ; z++) {
            if ($('#ddlMinute_' + z).length > 0) {
                if (!isNaN(parseInt($('#ddlMinute_' + z).val()))) {
                    if (_tempmin + parseInt($('#ddlMinute_' + z).val()) > 59) {
                        _carry = _carry + 1;
                    }
                    else { _tempmin = _tempmin + parseInt($('#ddlMinute_' + z).val()); }
                }
            }
        }
        if (_carry > 0) {
            _temptime = _temptime + _carry;
        }
        if (_temptime <= 9) {
            _temptime = "0" + _temptime;
        }
        if (_tempmin <= 9) {
            _tempmin = "0" + _tempmin;
        }
        $('#txtTotal').val(_temptime + ':' + _tempmin);
    }
    catch (e) {
        alert(e);
    }
}
function IsEmptyRow() {
    debugger;
    try {
        var _isempty = 0;
        var _ischecked = false;
        $('.required').each(function (index, data) {
            var _id = $(this).attr('id');
            _ischecked = true;
            if (($('#' + _id).val() == 0) || (isNaN($('#' + _id).val()))) {
                var _splitVal = _id.split('_')[1];
                _isempty = 0;
                switch ($(this).attr('name')) {
                    case 'SelectedProject':
                        $('#SelectedProject_' + _splitVal).css('visibility', 'visible');
                        break;
                    case 'SelectedPhase':
                        $('#SelectedPhase_' + _splitVal).css('visibility', 'visible');
                        break;
                    case 'SelectedModule':
                        $('#SelectedModule_' + _splitVal).css('visibility', 'visible');
                        break;
                    case 'SelectedTask':
                        $('#SelectedTask_' + _splitVal).css('visibility', 'visible');
                        break;
                    default:
                        alert('Invalid Selection');
                }
                return false;
            }
                //else if (isNaN($('#' + _id).val())) {
                //    _isempty = 0;
                //    return false;
                //}
            else {
                _isempty = 1;
            }
        });
        if (_ischecked == false)
        {
            return true;
        }
        else
        {
            if (_isempty == 0)
            { return false; }
            else
            {
                return true;
            }
        }
    }
    catch (e) {
        alert(e);
    }
}
function SaveWorkLogData() {
    var _timeHr = 0;
    var _timeMin = 0;
    var WorkLogDataArr = [];
    $('#ChkValidtime').css('visibility', 'hidden');
    if (IsEmptyRow() == false) {
        return false;
    }
    SetSerialNumber();
    Calculatetime();
    _timeHr = parseInt($('#txtTotal').val().split(':')[0]);
    _timemin = parseInt($('#txtTotal').val().split(':')[1]);
    if (isNaN(_timeHr)) { _timeHr = 0; }
    if (isNaN(_timemin)) { _timemin = 0; }
    if ((_timeHr == 0 && _timemin == 0) || (_timeHr > 23) || (_timemin > 59)) {
        $('#ChkValidtime').css('visibility', 'visible');
        return false;
    }
    //for (var i = 1; i <= $("#hdnViewRowCreated").val() ; i++)
    //{
    //    if ($('#ddlProject_' + i).length>0)
    //    {
            
    //        _timeHr = parseInt($('#ddlTime_' + i).val());
    //        _timemin = parseInt($('#ddlMinute_' + i).val());
    //        _timeHr = _timeHr * 60;
    //        _timemin = _timemin + _timeHr;
    //        WorkLogDataArr.push({
    //            workLogDate: $('#ddlworkDate').text(), Project_Id: parseInt($('#ddlProject_' + i).val()), Phase_Id: parseInt($('#PhasesList_' + i).val()), Module_id: parseInt($('#ddlModule_' + i).val()), Task_id: parseInt($('#ddlTask_' + i).val()), Time_spent: _timemin, Remarks: $('#txtPurpose_' + i).text()
    //        });
    //    }
    //}
    //$.ajax({
    //    type: 'Post',
    //    url: '/WorkLog/SubmitChanges',
    //    Datatype: 'Json',
    //    data: {List1:WorkLogDataArr},
    //    success: function (response) {

    //    },
    //    error: function (response) {
    //        alert(response);
    //    }
    //});
    return true;
}
function SetSerialNumber() {
    try {
        var ctnr = 1;
        var rowCount = $("#hdnViewRowCreated").val();
        for (var i = 1; i <= rowCount; i++) {
            if ($('#txtStatus_' + i).length > 0) {
                $('#hdnRowIndex_' + i).val(ctnr);
                $('#txtStatus_' + i).val(ctnr);
                //$('#hdnRowIndexNumber').val(ctnr);
                if (i + 1 <= rowCount) {
                    ctnr++;
                }
            }
        }
        if ($('#hdnViewStateCount').val() == null || $('#hdnViewStateCount').val() == '' || $('#hdnViewStateCount').val() == '0') {
            $('#hdnViewStateCount').val(1);
        }

        //$('#hdnRowIndexNumber').val(ctnr);
    }
    catch (e) {
        alert(e);
    }
}
function onSelectProject() {
    $.ajax({
        type: 'Get',
        url: '/WorkLog/Index',

        success: function (response) {
            //alert("hi");
        },
        error: function (response) {
            alert("Please select project !!!");
        }

    });
}
function CheckAllCheckBox() {
    debugger;
    try {
        for (z = 1; z <= $("#hdnViewRowCreated").val() ; z++) {
            if ($('#chkDelete_' + z).length > 0) {
                if ($('#CheckAlls').is(":checked")) {
                    //if ($('#chkDelete_' + z).is(":checked") == false) {
                    $('#chkDelete_' + z).prop("checked", true);
                    //}
                }
                else {
                    $('#chkDelete_' + z).prop("checked", false);
                }
            }
        }
    }
    catch (e) {
        alert(e);
    }
}

function fillProjectDetails(obj) {
    debugger;
    var prodVal = parseInt($('#ddlProject_' + obj).val());
    $('.displayError').css('visibility', 'hidden');
    if (!isNaN(prodVal) && prodVal > 0) {
        $('#valcProject_' + obj).css('visibility', 'hidden');
        $.ajax({
            type: 'Get',
            url: '/WorkLog/GetPhase',
            dataType: "JSON",
            data: { ProjectId: prodVal },
            success: function (response) {
                $('#PhasesList_' + obj).empty();
                $('#PhasesList_' + obj).append($('<option></option>').val('0').html('----Select----'));
                $.each(response, function (i, data) {
                    $("#PhasesList_" + obj).append(
                          $('<option></option>').val(data.PhaseId).html(data.PhaseName));
                });
            },
            error: function (response) {
                $('#PhasesList_' + obj).empty();
                $('#PhasesList_' + obj).append($('<option></option>').val('0').html('----Select----'));
                $('#ddlModule_' + obj).empty();
                $('#ddlModule_' + obj).append($('<option></option>').val('0').html('----Select----'));
                $('#ddlTask_' + obj).empty();
                $('#ddlTask_' + obj).append($('<option></option>').val('0').html('----Select----'));
                $('#txtPurpose_' + obj).val('');
                $('#SelectedProject__' + obj).css('visibility', 'visible');
            }
        });
        $.ajax({
            type: 'Get',
            url: '/WorkLog/GetModule',
            dataType: "JSON",
            data: { ProjectId: prodVal },
            success: function (response) {
                $('#ddlModule_' + obj).empty();
                $('#ddlModule_' + obj).append($('<option></option>').val('0').html('----Select----'));
                $.each(response, function (i, data) {
                    $("#ddlModule_" + obj).append(
                          $('<option></option>').val(data.ProjModule_Id).html(data.ModuleName));
                });
            },
            error: function (response) {
                $('#PhasesList_' + obj).empty();
                $('#PhasesList_' + obj).append($('<option></option>').val('0').html('----Select----'));
                $('#ddlModule_' + obj).empty();
                $('#ddlModule_' + obj).append($('<option></option>').val('0').html('----Select----'));
                $('#ddlTask_' + obj).empty();
                $('#ddlTask_' + obj).append($('<option></option>').val('0').html('----Select----'));
                $('#txtPurpose_' + obj).val('');
                $('#SelectedProject__' + obj).css('visibility', 'visible');
            }
        });
        $.ajax({
            type: 'Get',
            url: '/WorkLog/GetTask',
            dataType: "JSON",
            data: { ProjectId: prodVal },
            success: function (response) {
                $('#ddlTask_' + obj).empty();
                $('#ddlTask_' + obj).append($('<option></option>').val('0').html('----Select----'));
                $.each(response, function (i, data) {
                    $("#ddlTask_" + obj).append(
                          $('<option></option>').val(data.ProjTask_Id).html(data.TaskName));
                });
            },
            error: function (response) {
                $('#PhasesList_' + obj).empty();
                $('#PhasesList_' + obj).append($('<option></option>').val('0').html('----Select----'));
                $('#ddlModule_' + obj).empty();
                $('#ddlModule_' + obj).append($('<option></option>').val('0').html('----Select----'));
                $('#ddlTask_' + obj).empty();
                $('#ddlTask_' + obj).append($('<option></option>').val('0').html('----Select----'));
                $('#txtPurpose_' + obj).val('');
                $('#SelectedProject__' + obj).css('visibility', 'visible');
            }
        });
    }
    else {
        $('#PhasesList_' + obj).empty();
        $('#PhasesList_' + obj).append($('<option></option>').val('0').html('----Select----'));
        $('#ddlModule_' + obj).empty();
        $('#ddlModule_' + obj).append($('<option></option>').val('0').html('----Select----'));
        $('#ddlTask_' + obj).empty();
        $('#ddlTask_' + obj).append($('<option></option>').val('0').html('----Select----'));
        $('#txtPurpose_' + obj).val('');
        $('#SelectedProject_' + obj).css('visibility', 'visible');
    }
}
function SelectedPhase(obj) {
    debugger;
    try {
        var _split = $(obj).attr('id').split('_')[1];
        var phaseValue = $(obj).val();
        if (!isNaN(phaseValue)) {
            if (phaseValue == 0) {
                if (!isNaN(_split) || _split == 0) {
                    _split = 1;
                }
                $('#SelectedPhase_' + _split).css('visibility', 'visible');
            }
            else {
                $('#SelectedPhase_' + _split).css('visibility', 'hidden');
            }
        }
        else {
            $('#SelectedPhase_' + _split).css('visibility', 'hidden');
        }
    }
    catch (e) {
        alert(e);
    }
}
function SelectedModule(obj) {
    debugger;
    try {
        var _split = $(obj).attr('id').split('_')[1];
        var _Value = $(obj).val();
        if (!isNaN(_Value)) {
            if (_Value == 0) {
                if (!isNaN(_split) || _split == 0) {
                    _split = 1;
                }
                $('#SelectedModule_' + _split).css('visibility', 'visible');
            }
            else {
                $('#SelectedModule_' + _split).css('visibility', 'hidden');
            }
        }
        else {
            $('#SelectedModule_' + _split).css('visibility', 'hidden');
        }
    }
    catch (e) {
        alert(e);
    }
}
function SelectedTask(obj) {
    debugger;
    try {
        var _split = $(obj).attr('id').split('_')[1];
        var _Value = $(obj).val();
        if (!isNaN(_Value)) {
            if (_Value == 0) {
                if (!isNaN(_split) || _split == 0) {
                    _split = 1;
                }
                $('#SelectedTask_' + _split).css('visibility', 'visible');
            }
            else {
                $('#SelectedTask_' + _split).css('visibility', 'hidden');
            }
        }
        else {
            $('#SelectedTask_' + _split).css('visibility', 'hidden');
        }
    }
    catch (e) {
        alert(e);
    }
}
function OnAddNextClick(ObjProject, ObjPhase, ObjModule, ObjTask, ObjTimeSpent) {
    var value = $('#' + ObjProject).val();
    if (!isNaN(value)) {
        if (value == 0) {
            return false;
        }
    }
    else {
        return false;
    }
    value = $('#' + ObjPhase).val();
    if (!isNaN(value)) {
        if (value == 0) {
            return false;
        }
    }
    else {
        return false;
    }
    value = $('#' + ObjModule).val();
    if (!isNaN(value)) {
        if (value == 0) {
            return false;
        }
    }
    else {
        return false;
    }
    value = $('#' + ObjTask).val();
    if (!isNaN(value)) {
        if (value == 0) {
            return false;
        }
    }
    else {
        return false;
    }

    return true;
}
