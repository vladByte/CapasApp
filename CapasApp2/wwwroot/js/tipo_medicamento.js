window.onload = function (){
    listarTipoMedicamento();
}


function listarTipoMedicamento(res) {
    alert("Hola");
    alert("Tipo Medicamento");
    pintar({
        url: "TipoMedicamento/ListarTipoMedicamento",
        nomColumnas: ["id Tipo Medicamento", "Nombre", "Descripcion"],
        propiedades: ["idTipoMedicamento", "nombre", "descripcion"],
    });

}