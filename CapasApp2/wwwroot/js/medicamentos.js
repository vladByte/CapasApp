window.onload = function () {
    listarMedicamentos();
}

function listarMedicamentos() {

    fetchGet("Medicamentos/MedicamentosList", "json", function (res) {

        return res;
    }