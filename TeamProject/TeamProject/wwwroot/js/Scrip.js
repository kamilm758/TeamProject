var List=[];

$(document).ready(function () {
  
    $.ajax({
        url: '/Category/GetList',
        type: 'Post',
        dataType: 'json',
        data: { order: 'Call' },
        success: function (data) {
            List = data;
            console.log("ellllll")
            console.log(data);
            let parent = document.getElementById("Drzewo");
            let kutas = document.createElement("ul");
            parent.appendChild(kutas);
            parent = kutas;



            for (let i = 0; i < List.length; i++) {
                // console.log("tu jestem");

                if (List[i].parent == null) {
                    let textName = document.createTextNode(List[i].name);
                    let tdName = document.createElement("li");
                    tdName.setAttribute("class", "rodzic" + List[i].id);
                    tdName.setAttribute("onclick", " event.stopPropagation(); wyswietlDzieci(this)");
                    tdName.appendChild(textName);
                    parent.appendChild(tdName);
                }
            }
        },
        error: function (data) {
            console.log(data);
        }
   
    });


});

//function ello() {
//    let parent = document.getElementById("Drzewo");
//    let kutas = document.createElement("ul");
//    parent.appendChild(kutas);
//    parent = kutas;



//    for (let i = 0; i < List.length; i++) {
//       // console.log("tu jestem");
        
//        if (List[i].parent == null)
//        {
//            let textName = document.createTextNode(List[i].name);
//            let tdName = document.createElement("li");
//            tdName.setAttribute("class", "rodzic" + List[i].id);
//            tdName.setAttribute("onclick"," event.stopPropagation(); wyswietlDzieci(this)");
//            tdName.appendChild(textName);
//            parent.appendChild(tdName);
//        }
//    }
//}
function wyswietlDzieci(element) {
    
    console.log(element);
    let id = (element.className.slice(6));
   // element.innerText.style.fontWeight = "bolder";

    var div = document.getElementById('wynik');
    while (div.firstChild) {
        div.removeChild(div.firstChild);
    }
  
   
    //console.log(id);
    let ListaDzieci = [];
    $.ajax({
        url: '/Category/GetDzieci',
        type: 'Post',
        dataType: 'json',
        data: { order: id },
        success: function (data) {
           // ListaDzieci = data;
          //  console.log("sukces")
//            console.log(data);
            if (data.length > 0) {
                //let parent = document.getElementById("rodzic" + element);
                element.removeAttribute("onclick");
                element.setAttribute("onclick", "event.stopPropagation(); chowajDzieci(this)")
                let parent = element;
                let kutas = document.createElement("ul");
                for (let i = 0; i < data.length; i++) {
                    //console.log(data);
                    let textName = document.createTextNode(data[i].name);
                    let tdName = document.createElement("li");
                    tdName.setAttribute("class", "rodzic" + data[i].id);
                    tdName.setAttribute("onclick", " event.stopPropagation(); wyswietlDzieci(this)");
                    tdName.appendChild(textName);
                    kutas.append(tdName);
                 
                }
                parent.appendChild(kutas);
               
            }
            wyswietlFormularze(id);
        },
        error: function (data) {
         //   console.log(data);
            data = null;
        }

    });
  //  console.log(ListaDzieci.length);
    
   
}

function chowajDzieci(element) {

    element.removeChild(element.lastChild);
    element.removeAttribute("onclick");
    element.setAttribute("onclick", "event.stopPropagation(); wyswietlDzieci(this)")
   // element.firstChild.style.fontWeight = "900"; 
    console.log(element);

}


function wyswietlFormularze(id) {
    console.log("wyswietlFormularze")
    var parent = document.getElementById("wynik");
    console.log(parent)
    $.ajax({
        url: '/Forms/GetForms',
        type: 'Post',
        dataType: 'json',
        data: { order: id },
        success: function (data) {
            if (data.length > 0) {
               
                for (let i = 0; i < data.length; i++) {
                    //console.log(data);
                   // let form = document.createTextNode(data[i].name);
                    let element = document.createElement("div");
                    var button = $("<button>").attr("class", "btn").text(data[i].name).css("margin-bottom", "10px").click(function () {
                        window.location.href = '/Forms/Formularz/'+data[i].id;
                        return false;
                    });
                    var buttonEdit = $("<button>").attr("class", "btn").text("edytuj").css("margin-bottom", "10px").css("backgroundColor", "grey").click(function () {
                        window.location.href = '/Forms/EdycjaFormularza/'+ data[i].id;
                        return false;
                    });
                    button.appendTo(parent);
                    buttonEdit.appendTo(parent);


                  //  tdName.setAttribute("class", "rodzic" + data[i].id);
                    //   tdName.setAttribute("onclick", " event.stopPropagation(); wyswietlDzieci(this)");
                //    element.appendChild(button);
                    parent.appendChild(element);

                }
            }
        },
        error: function (data) {
            
        }

    });


}


//ello();
