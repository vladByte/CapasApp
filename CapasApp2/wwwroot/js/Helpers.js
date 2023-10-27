//Funciones Generales.

async function medicamentosGet(url, tipoRespuesta, callback)
{
    try
    {
        let raiz = document.getElementById("hdfOculto").value.trim();
        let baseUrl = `${window.location.protocol}//${window.location.host}${raiz}/${url}`;
        let res = await fetch(baseUrl);
        if (tipoRespuesta == "json") res = await res.json();
        callback(res)
    }       
    catch(e)
    {
        alert(`Error al listar Medicamentos: ${e}`);
    }
}