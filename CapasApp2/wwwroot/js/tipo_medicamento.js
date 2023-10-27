window.onload = function (){
    listarTipoMedicamento();
}


function listarTipoMedicamento() {

    medicamentosGet("TipoMedicamento/ListarTipoMedicamento", "json", function (res) {
        alert(res);
        alert(JSON.stringify(res));
    });
}