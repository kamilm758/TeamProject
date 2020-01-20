$(document).ready(function () {
    let val = sessionStorage.getItem("key");
    if (val != null) {
        let area = document.getElementById("searchPatient");
        area.value = sessionStorage.getItem("key")
        $.ajax({
            url: '/Patient/PatientForms/' + area.value,
            type: 'Get',
            dataType: 'json',
            data: { order: 'Call' },
            success: function (data) {
                console.log(data);
                createTable(data);
            },
            error: function (data) {
                console.log(data);
            }

        });
    }
});






$("#buttonSearch").click(function () {
    console.log(sessionStorage.getItem("key"))
    let area = document.getElementById("searchPatient");
    sessionStorage.setItem('key', area.value);
  
    

        $.ajax({
            url: '/Patient/PatientForms/' + area.value,
            type: 'Get',
            dataType: 'json',
            data: { order: 'Call' },
            success: function (data) {
                console.log(data);
                createTable(data);
            },
            error: function (data) {
                console.log(data);
            }

        });
    })
   
       
function createTable(data) {
    let container = $("#container")[0];

    for (let i = 0; i < data.length; i++) {
        let tr = document.createElement("tr");
        let td = document.createElement('td');
        var form = $(" <button>").attr("class", "btn-primary").text(data[i].nazwa_formularza).click(function () {
         window.location.href = '/Forms/Formularz/'+data[i].idForm;
            return false;
        });
        form.appendTo(td);
        tr.appendChild(td);
        container.appendChild(tr);
    }


}


