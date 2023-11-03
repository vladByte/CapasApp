window.onload = function (){
    listarTipoMedicamento();
}


function listarTipoMedicamento(res) {

    pintar({
        url: "TipoMedicamento/ListarTipoMedicamento",
        nomColumnas: ["id Tipo Medicamento", "Nombre", "Descripcion"],
        propiedades: ["idTipoMedicamento", "nombre", "descripcion"],
    });

}