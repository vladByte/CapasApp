//Funciones Generales.

async function fetchGet(url, tipoRespuesta, callback)
{

    var objConfiguracionGlobal;

    pintar({
        url: "TipoMedicamento/ListarTipoMedicamento",
        nomColumnas: ["id Tipo Medicamento", "Nombre","Descripcion"],
        propiedades: ["idTipoMedicamento", "nombre","descripcion"],
    });


    try
    {
        let raiz = document.getElementById('hdfOculto').value.trim();
        let baseUrl = `${window.location.protocol}//${window.location.host}${raiz}/${url}`;
        let res = await fetch(baseUrl);
        console.log("Respuesta: ", res);
        if (tipoRespuesta == 'json') res = await res.json();
        else if (tipoRespuesta == 'text') res = await res.text();
        //JSON (Object)
        callback(res);  
    }       
    catch(e)
    {
        alert(`Error al listar los elementos: ${e}`);
    }
}

/**
    * params  : res (array[{}])
    * return: json
    */
function generarTabla(res) {

    let cabecera = objConfiguracionGlobal.cabecera;
    let nombrePropiedades = objConfiguracionGlobal.propiedades;
    let contenido = "";

    contenido += "<table class='table'>";
    contenido += '<thead>';
    contenido += '<tr>';
    var item;
    for (let i = 0; i < cabecera.length; i++)
    {
        item = cabecera[i];
        contenido += `<td>${item.idTipoMedicamento}</td>`;
        contenido += `<td>${item.nombre}</td>`;
        contenido += `<td>${item.descripcion}</td>`;
    };
    contenido += '</tr>';
    contenido += '</thead>';
    contenido += '<tbody>';
    contenido += '<tr>';
    let num_registros = res.length;
    var obj;

    for (let i = 0; i < nombrePropiedades.length; i++) {
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

}

/**
* params  : url (string), nomColumnas (array[]), propiedades (array[])
* return: json
*/
function pintar(objConfiguracion) {

    objConfiguracionGlobal = objConfiguracion
    fetchGet(`${objConfiguracion.url}`, "json", function (res) {

        let contenido = "";
        contenido += generarTabla(res);
        document.getElementById("divTabla").innerHTML = contenido;


    });

}