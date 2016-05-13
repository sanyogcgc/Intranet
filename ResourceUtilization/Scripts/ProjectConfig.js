$(document).ready(function () {
    $("#loading").hide();
    $('#spnMsg').html('');
    $('#btnRight').click(function (e) {
        if ($('#ddlProject').val() != "") {
            var selectedOpts = $('#lstBxAllTask option:selected');
            if (selectedOpts.length == 0) {
                alert("Nothing to move.");
                e.preventDefault();
            }
            var exists = false;
            for (var i = 0; i < selectedOpts.length; i++) {
                $('#lstBxTaskSelect option').each(function () {
                    if (this.value == selectedOpts.val()) {
                        exists = true;
                    }
                })
                if (exists == false) {
                    $('#lstBxTaskSelect').append($(selectedOpts[i]).clone());
                    $(selectedOpts[i]).remove();
                    e.preventDefault();
                }
            }
        }
        else {
            alert('Please Select Project');
        }
    });

    $('#btnLeft').click(function (e) {
        if ($('#ddlProject').val() != "") {
            var selectedOpts = $('#lstBxTaskSelect option:selected');
            if (selectedOpts.length == 0) {
                alert("Nothing to move.");
                e.preventDefault();
            }
            var exists = false;
            for (var i = 0; i < selectedOpts.length; i++) {
                $('#lstBxAllTask option').each(function () {
                    if (this.value == selectedOpts.val()) {
                        exists = true;
                    }
                })
                if (exists == false) {
                    $('#lstBxAllTask').append($(selectedOpts[i]).clone());

                }
                $(selectedOpts[i]).remove();
                e.preventDefault();
            }
        }
        else {
            alert('Please Select Project');
        }
    });


    $('#btnRightTeam').click(function (e) {
        if ($('#ddlProject').val() != "") {
            var selectedOpts = $('#SelectedEmployees option:selected');
            if (selectedOpts.length == 0) {
                alert("Nothing to move.");
                e.preventDefault();
            }
            var exists = false;
            for (var i = 0; i < selectedOpts.length; i++) {
                $('#lstBxEmplyeProjectWise option').each(function () {
                    if (this.text == selectedOpts.text()) {
                        exists = true;
                    }
                })
                if (exists == false) {
                    $('#lstBxEmplyeProjectWise').append($(selectedOpts[i]).clone());
                    $(selectedOpts[i]).remove();
                    e.preventDefault();
                }
            }
        }
        else {
            alert('Please Select Project');
        }
    });

    $('#btnLeftTeam').click(function (e) {
        if ($('#ddlProject').val() != "") {
            var selectedOpts = $('#lstBxEmplyeProjectWise option:selected');
            if (selectedOpts.length == 0) {
                alert("Nothing to move.");
                e.preventDefault();
            }
            var exists = false;
            for (var i = 0; i < selectedOpts.length; i++) {
                $('#SelectedEmployees option').each(function () {
                    if (this.text == selectedOpts.text()) {
                        exists = true;
                    }
                })
                if (exists == false) {
                    $('#SelectedEmployees').append($(selectedOpts[i]).clone());

                }
                $(selectedOpts[i]).remove();
                e.preventDefault();
            }
        }
        else {
            alert('Please Select Project');
        }
    });
});

$('#btnRightAll').click(
 function (e) {
     if ($('#ddlProject').val() != "") {
         $("#lstBxAllTask option").prop("selected", true);
         var selectedOpts = $('#lstBxAllTask option:selected');
         var exists = false;
         for (var i = 0; i < selectedOpts.length; i++) {
             $('#lstBxTaskSelect option').each(function () {
                 if (this.value == selectedOpts.val()) {
                     exists = true;
                 }
             })
             if (exists == false) {
                 $('#lstBxAllTask > option:selected').appendTo('#lstBxTaskSelect');
                 e.preventDefault();
             }
         }
     }
     else {
         alert('please select Project');
     }
 });

$('#btnLeftAll').click(function (e) {
    if ($('#ddlProject').val() != "") {
        $("#lstBxTaskSelect option").prop("selected", true);
        var selectedOpts = $('#lstBxTaskSelect option:selected');

        var exists = false;
        for (var i = 0; i < selectedOpts.length; i++) {
            $('#lstBxAllTask option').each(function () {
                if (this.value == selectedOpts.val()) {
                    exists = true;
                }
            })
            if (exists == false) {
                $('#lstBxTaskSelect > option:selected').appendTo('#lstBxAllTask');

            }
            $('#lstBxTaskSelect > option:selected').remove();
            e.preventDefault();
        }
    }
    else {
        alert('Please Select Project');
    }
});

$('#btnRightAllTeam').click(
function (e) {
    if ($('#ddlProject').val() != "") {
        $("#SelectedEmployees option").prop("selected", true);
        var selectedOpts = $('#SelectedEmployees option:selected');
        var exists = false;
        for (var i = 0; i < selectedOpts.length; i++) {
            $('#lstBxEmplyeProjectWise option').each(function () {
                if (this.text == selectedOpts.text()) {
                    exists = true;
                }
            })
            if (exists == false) {
                $('#SelectedEmployees > option:selected').appendTo('#lstBxEmplyeProjectWise');
                e.preventDefault();
            }
        }
    }
    else {
        alert('please select Project');
    }
});

$('#btnLeftAllTeam').click(function (e) {
    if ($('#ddlProject').val() != "") {
        $("#lstBxEmplyeProjectWise option").prop("selected", true);
        var selectedOpts = $('#lstBxEmplyeProjectWise option:selected');

        var exists = false;
        for (var i = 0; i < selectedOpts.length; i++) {
            $('#SelectedEmployees option').each(function () {
                if (this.value == selectedOpts.val()) {
                    exists = true;
                }
            })
            if (exists == false) {
                $('#lstBxEmplyeProjectWise > option:selected').appendTo('#SelectedEmployees');

            }
            $('#lstBxEmplyeProjectWise > option:selected').remove();
            e.preventDefault();
        }
    }
    else {
        alert('Please Select Project');
    }
});

function loaddata() {
    if ($('#ddlProject').val() != "") {
        $("#loading").show();
        var projectID = $('#ddlProject').val();
        $.ajax({
            url: '/ProjectConfig/GetProposedEstEfforts?projectId=' + projectID,
            type: "GET",
            // data: { ProjectConfigViewModel: ProjectConfigViewModel },
            dataType: "JSON",
            success: function (ProjectConfigViewModel) {
                // alert(response.responseText);
                var dropdown = $('#lstbxModule');
                dropdown.empty();
                $("#lblModuleMsg").empty();
                $("#lblPhaseMsg").empty();
                $('#txtItem').val("");
                $('#txtModuleTime').val("");
                $("#txtPhase").val("");
                $("#txtPhaseTime").val("");
                $("#hdnOptionVal").val("");
                $("#hdnModuleVal").val("");
                $('#chkModule').prop('checked', false);
                $('#txt').empty();
                $('#lstBxTaskSelect').empty();
                $('#lstBxEmplyeProjectWise').empty();
                $("#spnEstEffrt").html("");
                $('#spnMsg').html('');
                $("#spnEstEffrt").append(ProjectConfigViewModel.ProposedEstEfforts);

                //  $("#txt").attr('size', ProjectConfigViewModel.phaseList.length);
                for (var index = 0; index < ProjectConfigViewModel.phaseList.length; index++) {
                    var option = ProjectConfigViewModel.phaseList[index];
                    $("#txt").append('<option value="' + option.Phaseid + '">' + option.PhaseName + '</option>');
                }

                $("#lstbxModule").attr('size', ProjectConfigViewModel.ProjModuleList.length);
                for (var index = 0; index < ProjectConfigViewModel.ProjModuleList.length; index++) {
                    var option = ProjectConfigViewModel.ProjModuleList[index];
                    $("#lstbxModule").append('<option value="' + option.ProjModule_Id + '">' + option.ModuleName + '</option>');
                }

                for (var index = 0; index < ProjectConfigViewModel.taskList.length; index++) {
                    var option = ProjectConfigViewModel.taskList[index];
                    $("#lstBxTaskSelect").append('<option value="' + option.ProjTask_Id + '">' + option.TaskName + '</option>');
                }

                for (var index = 0; index < ProjectConfigViewModel.EmployeeList.length; index++) {
                    var option = ProjectConfigViewModel.EmployeeList[index];
                    $("#lstBxEmplyeProjectWise").append('<option value="' + option.Emp_Id + '">' + option.EmployeeName + '</option>');
                }
                $("#txtPlnnedEffrt").append(ProjectConfigViewModel.ProposedEstEfforts);
                //$("#ddlPM").val(ProjectConfigViewModel.TeamLeader);
                $('#ddlTeamLeader').val(ProjectConfigViewModel.TeamLeader_Second).attr("selected", "selected");
                $('#ddlPM').val(ProjectConfigViewModel.TeamLeader).attr("selected", "selected");
                // $('select[name^="SelectedEmployeePM"] option[value='+ProjectConfigViewModel.TeamLeader+']').attr("selected", "selected");
                // $("#ddlPM > [value=" + ProjectConfigViewModel.TeamLeader + "]").attr("selected", "true");
                // $('#ddlPM option[value='+ ProjectConfigViewModel.TeamLeader +']').attr("selected", "selected");
                if (ProjectConfigViewModel.ProjModuleList.length > 0) {
                    $('#chkModule').prop('checked', true);
                }
                CalculatePlannedEffort();
                $("#loading").hide();
            },
            error: function (response) {
                $("#loading").hide();
                alert(response.responseText);

            },
        });
    }
}

function fillModule() {
    // $("#lstbxModule").click(function () {
    var _this = $("#lstbxModule :selected");
    var data = $('#lstbxModule :selected').text();
    var arr = data.split(':');
    $("#txtItem").val(arr[0]);
    $("#txtModuleTime").val(arr[1]);
    var ModuleID = $('#lstbxModule :selected').val();
    $("#hdnModuleVal").val(ModuleID);
    // alert(ModuleID);

    // $("#txtItem").val($(_this).text());
    // alert($('#lstbxModule :selected').text());;
    // });
};

function fillPhases() {
    var data = $('#ddlPhaseAll :selected').text();
    $("#txtPhase").val(data);
    var PhaseID = $('#ddlPhaseAll :selected').val();
    $("#hdnOptionVal").val(PhaseID);

    // alert(PhaseID);
}

function fillPhasePrjt() {
    var data = $('#txt :selected').text();
    var arr = data.split(':');
    $("#txtPhase").val(arr[0]);
    $("#txtPhaseTime").val(arr[1]);
    var PhaseID = $('#txt :selected').val();
    $("#hdnOptionVal").val(PhaseID);
    // alert(PhaseID);
}

function AddNwPhase() {
    var exists = false;
    if ($('#ddlProject').val() != "") {
        if ($("#txtPhase").val().length > 0) {
            if ($("#txtPhaseTime").val().length > 0) {
                $('#txt option').each(function () {
                    if (this.value == $('#hdnOptionVal').val()) {
                        exists = true;
                        //  alert('already exists');
                        $("#lblPhaseMsg").empty();
                        $("#lblPhaseMsg").append(" already exists");
                        return false;
                    }
                });
                if (exists == false) {
                    var valAdd = $('#txtPhase').val() + ":" + $('#txtPhaseTime').val();
                    $('#txt').append($('<option value="' + $('#hdnOptionVal').val() + '">' + valAdd + '</option>'));
                    $("#lblPhaseMsg").empty();
                    $("#lblPhaseMsg").append("New Phase Added");
                }

            }
            else {
                // alert('Add Phase Time');
                $("#lblPhaseMsg").empty();
                $("#lblPhaseMsg").append("Add Phase Time");
            }
        }
        else {
            $("#lblPhaseMsg").empty();
            $("#lblPhaseMsg").append("Please select Phase");
        }
    }
    else {
        $("#lblPhaseMsg").empty();
        $("#lblPhaseMsg").append("Please Select Project");
        // alert('Please Select Project!');
    }
    CalculatePlannedEffort();
}

function ModifyPhase() {
    var exists = true;
    if ($('#ddlProject').val() != "") {
        if ($("#txtPhase").val().length > 0) {
            if ($("#txtPhaseTime").val().length > 0) {
                $('#txt option').each(function () {
                    if (this.value == $('#hdnOptionVal').val()) {
                        exists = true;
                        var valAdd = $('#txtPhase').val() + ":" + $('#txtPhaseTime').val();
                        $('#txt option[value="' + $('#hdnOptionVal').val() + '"]').text(valAdd);

                    }
                    //else {
                    //    alert('Not exists');
                    //    return false;
                    //}
                });
                $("#lblPhaseMsg").empty();
                $("#lblPhaseMsg").append("Phase Modified");
            }
            else {
                //alert('Add Phase Time');
                $("#lblPhaseMsg").empty();
                $("#lblPhaseMsg").append("Add Phase Time");
            }
        }
        else {
            $("#lblPhaseMsg").empty();
            $("#lblPhaseMsg").append("Please select Phase");
        }
    }
    else {
        //  alert('Please Select Project!');
        $("#lblPhaseMsg").empty();
        $("#lblPhaseMsg").append("Please Select Project");
    }
    CalculatePlannedEffort();
}

function RemovePhase() {

    if ($('#ddlProject').val() != "") {
        if ($("#txtPhase").val().length > 0) {
            $('#txt option').each(function () {
                if (this.value == $('#hdnOptionVal').val()) {
                    // exists = true;
                    //var valAdd = $('#txtPhase').val() + ":" + $('#txtPhaseTime').val();
                    // $('#txt option[value="' + $('#hdnOptionVal').val() + '"]').text(valAdd);
                    $('#txt option[value="' + $('#hdnOptionVal').val() + '"]').remove();
                }
            });
            $("#lblPhaseMsg").empty();
            $("#lblPhaseMsg").append("Phase deleted");
        }
        else {
            $("#lblPhaseMsg").empty();
            $("#lblPhaseMsg").append("Please select Phase");
        }

    }
    else {
        $("#lblPhaseMsg").empty();
        $("#lblPhaseMsg").append("Please Select Project");
    }
    CalculatePlannedEffort();
}

function AddNwModule() {
    if ($('#ddlProject').val() != "") {
        if ($('#chkModule').is(":checked")) {
            exists = false;
            if ($("#txtItem").val().length > 0) {
                if ($("#txtModuleTime").val().length > 0) {
                    $('#lstbxModule option').each(function () {
                        var textdata = this.text;
                        // textdata.split(':');
                        var arr = textdata.split(':');
                        //alert(arr[0]);
                        if (arr[0] == $('#txtItem').val()) {
                            exists = true;
                            // alert('already exists');
                            $("#lblModuleMsg").empty();
                            $("#lblModuleMsg").append(" already exists");
                            return false;
                        }
                        // else {

                    });

                    if (exists == false) {
                        var valAdd = $('#txtItem').val() + ":" + $('#txtModuleTime').val();
                        $('#lstbxModule').append($('<option value="' + "" + '">' + valAdd + '</option>'));
                        $("#lblModuleMsg").empty();
                        $("#lblModuleMsg").append("Module Added ");
                    }
                }
                else {
                    // lblModuleMsg
                    //$('#spnMsg').html('Add Module Time');
                    $("#lblModuleMsg").empty();
                    $("#lblModuleMsg").append("Add Module Time");
                    //  alert('Add Module Time');
                }
            }
            else {
                // alert('Add Module Name');
                $("#lblModuleMsg").empty();
                $("#lblModuleMsg").append("Add Module Name");
            }

        }
        else {
            // alert("please tick checkbox");
            $("#lblModuleMsg").empty();
            $("#lblModuleMsg").append("please tick checkbox");
        }
    }
    else {
        $("#lblModuleMsg").empty();
        $("#lblModuleMsg").append("Please Select Project");
        // alert('Please Select Project');
    }
}

function ModifyModule() {
    exists = false;
    if ($('#ddlProject').val() != "") {
        if ($('#txtModuleTime').val() != "") {
            if ($('#txtItem').val() != "") {
                $('#lstbxModule option').each(function () {
                    if (this.value == $('#hdnModuleVal').val()) {
                        exists = true;
                        var valAdd = $('#txtItem').val() + ":" + $('#txtModuleTime').val();
                        $('#lstbxModule option[value="' + $('#hdnModuleVal').val() + '"]').text(valAdd);

                    }
                });
                $("#lblModuleMsg").empty();
                $("#lblModuleMsg").append("Module Modified ");
            }
            else {
                // alert('Please add Module Name');
                $("#lblModuleMsg").empty();
                $("#lblModuleMsg").append("Please add Module Name");
            }
        }
        else {
            // alert('please add time');
            $("#lblModuleMsg").empty();
            $("#lblModuleMsg").append("please add time");;
        }
    }
    else {
        alert('Please Select Project');
    }

}

function DeleteModule() {

    if ($('#ddlProject').val() != "") {
        $('#lstbxModule option').each(function () {
            if (this.value == $('#hdnModuleVal').val()) {
                // exists = true;
                //var valAdd = $('#txtPhase').val() + ":" + $('#txtPhaseTime').val();
                // $('#txt option[value="' + $('#hdnOptionVal').val() + '"]').text(valAdd);
                $('#lstbxModule option[value="' + $('#hdnModuleVal').val() + '"]').remove();
            }
        });
        $("#lblModuleMsg").empty();
        $("#lblModuleMsg").append("Module Deleted ");

    }
    else {
        alert('Please Select Project');
    }
}

function CalculatePlannedEffort() {
    var sum = 0;
    $('#txt option').each(function () {
        var data = this.text;
        arr = data.split(':');
        sum += parseInt(arr[1]);
    })
    $('#txtPlnnedEffrt').val(sum);
}

function EmployeeBusinsUnitWise() {
    if ($('#ddlBusinessUnit').val() != "") {
        var unitID = $('#ddlBusinessUnit').val();
        $.ajax({
            url: '/ProjectConfig/GetEmployeeUnitWise?unitID=' + unitID,
            type: "GET",
            dataType: "JSON",
            success: function (ProjectConfigViewModel) {
                $('#SelectedEmployees').empty();
                for (var index = 0; index < ProjectConfigViewModel.EmployeeList.length; index++) {
                    var option = ProjectConfigViewModel.EmployeeList[index];
                    $("#SelectedEmployees").append('<option value="' + option.Emp_Id + '">' + option.EmployeeName + '</option>');
                }

            },
            error: function (response) {
                alert(response.responseText);
            },
        });
    }
}

function SubmitData() {
    if ($('#ddlProject').val() != "") {
        $("#loading").show();
        // var ProjectTimeViewModel = [];
        var Phase = [];
        var Pid = $('#ddlProject').val();
        var PassData = [];
        ($("#txt option").prop("selected", true)).val;
        $("#txt option").each(function () {
            var Mandays;
            var optionTexts;
            Mandays = ($(this).text());
            optionTexts = ($(this).val())
            if (Pid != "") {
                Phase.push({ ProjectId: Pid, PhaseName: Mandays, PhaseId: optionTexts });
            }
        });
        // PassData[0] = ProjectTimeViewModel;
        // var ProjectTimeViewModel1=[];
        var Module = [];
        $("#lstbxModule option").prop("selected", true);
        $("#lstbxModule option").each(function () {
            var Modulename;
            var ModuleID;
            Modulename = ($(this).text());
            ModuleID = ($(this).val())
            if (Pid != "") {
                Module.push({ ProjectId: Pid, ModuleName: Modulename, ModuleID: ModuleID });
            }
        });
        // PassData[1] = ProjectTimeViewModel1;
        // debugger;
        // var ProjectTimeViewModel2 = [];
        var Task = [];
        $("#lstBxTaskSelect option").prop("selected", true);
        $("#lstBxTaskSelect option").each(function () {
            var TaskID;
            var TaskName;
            // Modulename = ($(this).text());
            TaskID = ($(this).val())
            TaskName = ($(this).text());
            if (Pid != "") {
                Task.push({ ProjectId: Pid, TaskID: TaskID, TaskName: TaskName });
            }
        });
        //  PassData[2] = ProjectTimeViewModel2;

        //  var ProjectTimeViewModel3 = [];
        var Team = [];
        $("#lstBxEmplyeProjectWise option").prop("selected", true);
        $("#lstBxEmplyeProjectWise option").each(function () {
            var TeamID;
            var TeamName;
            // Modulename = ($(this).text());
            TeamID = ($(this).val())
            TeamName = ($(this).text());
            if (Pid != "") {
                Team.push({ ProjectId: Pid, TeamID: TeamID, TeamName: TeamName });
            }
        });
        // PassData[3] = ProjectTimeViewModel3;
        if ($('#ddlPM').val() != "") {
            var teamlead = $('#ddlPM :selected').val();
        }
        else {
            teamlead = 0;
        }
        if ($('#ddlTeamLeader').val() != "") {
            var secondTL = $('#ddlTeamLeader :selected').val();
        }
        else {
            secondTL = 0;
        }
        $.ajax({



            url: '/ProjectConfig/SubmitChanges',
            type: "POST",
            dataType: "JSON",
            data: { Phase: Phase, Module: Module, Task: Task, Team: Team, teamlead: teamlead, secondTL: secondTL },
            // data: { ProjectTimeViewModel: PassData },
            success: function (ProjectConfigViewModel) {
                $("#loading").hide();
                $('#spnMsg').html('Configuration saved Successfully');

                // $('#SelectedEmployees').empty();
                //for (var index = 0; index < ProjectConfigViewModel.EmployeeList.length; index++) {
                //    var option = ProjectConfigViewModel.EmployeeList[index];
                //    $("#SelectedEmployees").append('<option value="' + option.Emp_Id + '">' + option.EmployeeName + '</option>');
                //}
            },
            error: function (response) {
                $("#loading").hide();
                alert(response.responseText);
            },
        });
    }
    else {
        alert('Please select Project');
    }
}

//$("#txtItem").keypress(function (e) {
//   var charCode = !e.charCode ? e.which : e.charCode;

//    if (':') {
//        alert('nn');
//        e.preventDefault();
//    }
//})


$("#txtPhaseTime").keydown(function (event) {
    // Allow only backspace and delete
    if (event.keyCode == 46 || event.keyCode == 8) {
        // let it happen, don't do anything
    }
    else {
        // Ensure that it is a number and stop the keypress
        if (event.keyCode < 48 || event.keyCode > 57) {
            event.preventDefault();
        }
    }
});

$("#txtModuleTime").keydown(function (event) {
    // Allow only backspace and delete
    if (event.keyCode == 46 || event.keyCode == 8) {
        // let it happen, don't do anything
    }
    else {
        // Ensure that it is a number and stop the keypress
        if (event.keyCode < 48 || event.keyCode > 57) {
            event.preventDefault();
        }
    }
});

//$("#txtPhaseTime").validate();
//jQuery.validator.addMethod("specialChar", function (value, element) {
//    return this.optional(element) || /([0-9a-zA-Z\s])$/.test(value);
//}, "Please Fill Correct Value in Field.");

$('#txtModuleTime').keydown(function (e) {
    if (e.shiftKey || e.ctrlKey || e.altKey) {
        e.preventDefault();
    } else {
        var key = e.keyCode;
        if (!((key == 8) || (key == 46) || (key >= 35 && key <= 40) || (key >= 48 && key <= 57) || (key >= 96 && key <= 105))) {
            e.preventDefault();
        }
    }
});

$('#txtPhaseTime').keydown(function (e) {
    if (e.shiftKey || e.ctrlKey || e.altKey) {
        e.preventDefault();
    } else {
        var key = e.keyCode;
        if (!((key == 8) || (key == 46) || (key >= 35 && key <= 40) || (key >= 48 && key <= 57) || (key >= 96 && key <= 105))) {
            e.preventDefault();
        }
    }
});