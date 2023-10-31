window.onload = function () {
    listarMedicamentos();
}

function listarMedicamentos() {

    fetchGet("Medicamentos/MedicamentosList", "json", function (res) {
        alert(res);
        alert(JSON.stringify(res));
    }