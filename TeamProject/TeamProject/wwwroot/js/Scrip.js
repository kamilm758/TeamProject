﻿var List=[];
var ostatni;

$(document).ready(function () {

    let parentButton = document.getElementById("buton");
    var addCategory = $(" <button>").attr("class", "btn").text("dodaj nową kategorię główną").css("margin-bottom", "10px").css("backgroundColor", "#fafae7").click(function () {
       
        window.location.href = '/Category/CreateParentCategory';
        return false;
    });
    addCategory.appendTo(parentButton);

    let parent = document.getElementById("Drzewo");
    if (sessionStorage.getItem('todoList') && IDcat != 1 ) {
        if (sessionStorage.getItem('todoList')) {
            var listContents = JSON.parse(sessionStorage.getItem('todoList'));
          
            var $drzewo = $("#Drzewo");
            str = listContents;
            html = $.parseHTML(str);
           
            $drzewo.append(html);
        }
    }
      else
    //loadToDo();
    $.ajax({
        url: '/Category/GetList',
        type: 'Post',
        dataType: 'json',
        data: { order: 'Call' },
        success: function (data) {
            List = data;
      
            

      
           // let parent = document.getElementById("Drzewo");
            let ul = document.createElement("ul");
            parent.appendChild(ul);
            parent = ul;



            for (let i = 0; i < List.length; i++) {
         

                if (List[i].parent == null) {
                    
                    var li = $(" <li>").attr("id", List[i].id).attr("class", "rodzic").text(List[i].name).css("margin-bottom", "10px");//.css("backgroundColor", "#fcfcf2");
                    
                
                    li.appendTo(parent);
                }
            }
        },
        error: function (data) {
            console.log(data);
        }
   
    });


});


$(document).on('click', '.rodzic', function (e) {
    // process code
    $('.btn1').remove()
    e.stopPropagation();
    let parent = e.currentTarget;
    ostatni = parent;
    id = e.currentTarget.id;
    chowajFormularze();
    var buttonAdd = $(" <button>").attr("class", "btn1").text("Dodaj formularz").css("margin-bottom", "10px").css("backgroundColor", "#fafae7").click(function () {
        let listContents = $("#Drzewo").html();
        sessionStorage.setItem('todoList', JSON.stringify(listContents));
        window.location.href = '/Forms/Create/' + id;
        return false;
    });
    buttonAdd.appendTo(parent);
    var buttonAddCat = $(" <button>").attr("class", "btn1").text("Dodaj kategorie").css("margin-bottom", "10px").css("backgroundColor", "#f1f1bb").click(function () {
        let listContents = $("#Drzewo").html();
        sessionStorage.setItem('todoList', JSON.stringify(listContents));
        window.location.href = '/Category/Create/' + id;
        return false;
    });
    buttonAddCat.appendTo(parent);
    
   console.log(e);
    let ListaDzieci = [];
    $.ajax({
        url: '/Category/GetDzieci',
        type: 'Post',
        dataType: 'json',
        data: { order: id },
        success: function (data) {
            console.log(data);
   
            if (data.length > 0) {
         
                
                parent.setAttribute("class", "rodzicX");
            
                let ul = document.createElement("ul");
                for (let i = 0; i < data.length; i++) {
                  
                    let textName = document.createTextNode(data[i].name);
                    let tdName = document.createElement("li");
                    tdName.setAttribute("class", "rodzic");
                    tdName.setAttribute("id", data[i].id);
                
                    tdName.appendChild(textName);
                    ul.append(tdName);
                 
                }
                parent.appendChild(ul);
               
            }
            wyswietlFormularze(id);
            let listContents = $("#Drzewo").html();
            sessionStorage.setItem('todoList', JSON.stringify(listContents));
        },
        error: function (data) {
    
            data = null;
        }

    });
  
    $(this).off('click');
   
});

$(document).on('click', '.rodzicX', function (e) {
    
    $('.btn1').remove();


    console.log(e);
    
    e.stopPropagation();
    id = e.currentTarget.id;
    let parent = e.currentTarget;
    
    chowajDzieci(parent);
    wyswietlFormularze(id);
    var buttonAdd = $(" <button>").attr("class", "btn1").text("Dodaj formularz").css("margin-bottom", "10px").css("backgroundColor", "#fafae7").click(function () {
        let listContents = $("#Drzewo").html();
        sessionStorage.setItem('todoList', JSON.stringify(listContents));
        window.location.href = '/Forms/Create/' + id;
        return false;
    });
    buttonAdd.appendTo(parent);
  
    var buttonAddCat = $(" <button>").attr("class", "btn1").text("Dodaj kategorie").css("margin-bottom", "10px").css("backgroundColor", "#f1f1bb").click(function () {
        let listContents = $("#Drzewo").html();
        sessionStorage.setItem('todoList', JSON.stringify(listContents));
        window.location.href = '/Category/Create/' + id;
        return false;
    });
    buttonAddCat.appendTo(parent);
    let listContents = $("#Drzewo").html();
    sessionStorage.setItem('todoList', JSON.stringify(listContents));
  
    $(this).off('click');

});


function chowajDzieci(element) {

    element.removeChild(element.lastChild);
   // element.removeAttribute("onclick");
    element.setAttribute("class", "rodzic");
   // element.setAttribute("onclick", "event.stopPropagation()");
   // element.firstChild.style.fontWeight = "900"; 
    console.log(element);
    var div = document.getElementById('wynik');
   while (div.firstChild) {
       div.removeChild(div.firstChild);
   }

}

function chowajFormularze(element) {
    var div = document.getElementById('wynik');
    while (div.firstChild) {
        div.removeChild(div.firstChild);
    }
}


function wyswietlFormularze(id) {
    console.log("wyswietlFormularze")
    var parent = document.getElementById("wynik");
    console.log(id)
    $.ajax({
        url: '/Forms/GetForms',
        type: 'Post',
        dataType: 'json',
        data: { order: id },
        success: function (data) {
            console.log(data);
            if (data.length > 0) {
               
                for (let i = 0; i < data.length; i++) {
                 
                    let element = document.createElement("div");
                    var button = $("<button>").attr("class", "btn").text(data[i].name).css("margin-bottom", "10px").click(function () {
                        let listContents = $("#Drzewo").html();
                        sessionStorage.setItem('todoList', JSON.stringify(listContents));
                        window.location.href = '/Forms/Formularz/' + data[i].id;
                        return false;
                    });
                    var buttonEdit = $("<button>").attr("class", "btn").text("edytuj").css("margin-bottom", "10px").css("backgroundColor", "grey").click(function () {
                        let listContents = $("#Drzewo").html();
                        sessionStorage.setItem('todoList', JSON.stringify(listContents));
                        window.location.href = '/Fields/AddNewField/' + data[i].id;
                        return false;
                    });
                    button.appendTo(parent);
                    var buttonShow = $("<button>").attr("class", "btn").text("wyświetl wyniki formularza").css("margin-bottom", "10px").css("backgroundColor", "#d2d2d2").click(function () {
                        let listContents = $("#Drzewo").html();
                        sessionStorage.setItem('todoList', JSON.stringify(listContents));
                        window.location.href = '/UserAnswerLists/AnswerListPost/' + data[i].id;
                        return false;
                    });
                    buttonShow.appendTo(parent);
                    buttonEdit.appendTo(parent);

                    parent.appendChild(element);

                }
            }
        },
        error: function (data) {
            
        }

    });


}



