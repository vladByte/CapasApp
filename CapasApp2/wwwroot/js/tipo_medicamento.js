window.onload = function (){
    listarTipoMedicamento();
}


function listarTipoMedicamento(res) {

    fetchGet("TipoMedicamento/ListarTipoMedicamento", "json", function (res) {
       
        let contenido = '';
        contenido += "<table class='table'>";
        contenido += '<thead>';
        contenido += '<tr>';
        contenido += '<td>ID</td>';
        contenido += '<td>Nombre</td>';
        contenido += '<td>Descripcion</td>';
        contenido += '</tr>';
        contenido += '</thead>';
        contenido += '<tbody>';
        contenido += '<tr>';
        let num_registros = res.length;
        var obj;
        
        for (let i = 0; i < num_registros; i++) {
            obj = res[i];
            contenido += '<tr>';
            contenido += `<td>${obj.idTipoMedicamento}</td>`;
            contenido += `<td>${obj.nombre}</td>`;
            contenido += `<td>${obj.descripcion}</td>`;
            contenido += '</tr>';
        }

        contenido += '</tr>';
        contenido += '</tbody>';
        contenido += '</table>';
        document.getElementById("divtabla").innerHTML = contenido;
    });
}