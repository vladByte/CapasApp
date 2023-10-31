//Funciones Generales.

async function fetchGet(url, tipoRespuesta, callback)
{
    try
    {
        let raiz = document.getElementById('hdfOculto').value.trim();
        let baseUrl = `${window.location.protocol}//${window.location.host}${raiz}/${url}`;
        let res = await fetch(baseUrl);

        if (tipoRespuesta == 'json') res = await res.json();
        else if (tipoRespuesta == 'text') res = 'text';
        callback(res) res = await res.text();
    }       
    catch(e)
    {
        alert(`Error al listar los elementos: ${e}`);
    }
}