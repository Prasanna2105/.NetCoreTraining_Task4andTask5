$.get("http://localhost:5169/api/Employees/GetEmployees", function (data, status) {

    if (data) {
        let code = ""
        for (let x in data) {
            code += "<tr>"
            code += "<td>" + data[x].employee_name + "</td>"
            code += "<td>" + data[x].status + "</td>"
            code += "<td>" + data[x].manager + "</td>"
            code += "<td>" + data[x].wfm_manager + "</td>"
            code += "<td>" + data[x].email + "</td>"
            code += "<td>" + data[x].lockstatus + "</td>"
            code += "<td>" + data[x].experience + "</td>"
            code += "<td>" + data[x].skills + "</td>"
            code += "</tr>"
        }
        $("#tdata").html(code)
    }

})