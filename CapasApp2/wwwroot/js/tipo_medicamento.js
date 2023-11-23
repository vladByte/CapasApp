window.onload = function (){
    listarTipoMedicamento();
}


function listarTipoMedicamento(res) {
    pintar({
        url: "TipoMedicamento/ListarTipoMedicamento",
        cabecera: ["id Tipo Medicamento", "Nombre", "Descripcion"],
        propiedades: ["idTipoMedicamento", "Nombre", "Descripcion"],
    });

}