window.onload = function () {
    listarMedicamentos();
}

function listarMedicamentos() {

    fetchGet("Medicamentos/ListarTipoMedicamento", "json", function (res) {
        alert(res);
        alert(JSON.stringify(res));

}