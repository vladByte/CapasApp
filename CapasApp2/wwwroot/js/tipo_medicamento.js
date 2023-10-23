window.onload = function (){
    listarTipoMedicamento();
}

async function listarTipoMedicamento() {

    let res = await fetch("TipoMedicamento/ListarTipoMedicamento")
        .then(res => res.json())
        .then(res => console.log(res))
        .catch(err => console.error(err));
}