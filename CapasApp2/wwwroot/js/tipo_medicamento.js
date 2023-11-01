window.onload = function (){
    listarTipoMedicamento();
}


function listarTipoMedicamento() {

    fetchGet("TipoMedicamento/ListarTipoMedicamento", "json", function (res) {
        alert(JSON.stringify(res));

        let contennido = '';
        contenido += '<table>';
        contenido += '<thead>';
        contenido += '<tr>';
        contenido += '<td>ID</td>';
        contenido += '<td>Nombre</td>';
        contenido += '<td>Descripcion</td>';
        contenido += '</tr>';
        contenido += '</thead>';
        contenido += '<tr>';
        let num_registros = res.lenght;
        for (let i = 0; i < num_registros; i++) {
            `<td> ${res[i]}</td>`
            
        }
        contenido += '<tr>';
    });
}