window.onload = function (){
    listarTipoMedicamento();
}


function listarTipoMedicamento() {

    fetchGet("TipoMedicamento/ListarTipoMedicamento", "json", function (res) {
        alert(JSON.stringify(res));
    });
}