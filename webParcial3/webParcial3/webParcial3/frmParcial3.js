var dir = "http://localhost:56740/api/";     // Dirección Servidor

jQuery(function () {

    $("#btnLimpiar").on("click", function () {
        alert("limpiar");
        Limpiar();
    });
    $("#btnProcesar").on("click", function () {
        alert("Procesar");
        Procesar();
    });
})

    function Limpiar() {
        $("#txtCodigo").val("");
        $("#txtVrHora").val("");
        $("#txtCantHoras").val("");
        $("#txtVrRecargo1").val("");
        $("#txtVrRecargo2").val("");
        $("#txtCantDom").val("");
        $("#txtVrDom").val("");
        $("#txtProp").val("");
        $("#txtSalNorm").val("");
        $("#txtSalExth16").val("");
        $("#txtSalExtd16").val("");
        $("#txtSubTot").val("");
        $("#txtPagoDom").val("");
        $("#txtTotal").val("");
    }
    
async function Procesar() {  //Definir variables de entrada
        let Codigo = $("#txtCodigo").val();
        let VrHora = $("#txtVrHora").val();
        let CantHoras = $("#txtCantHoras").val().trim();
        let Recargo1 = $("#txtVrRecargo1").val();
        let Recargo2 = $("#txtVrRecargo2").val();
        let CantDom= $("#txtCantDom").val();
        let ValorDom = $("#txtVrDom").val();

    if (Codigo == "") {
        alert("Error, escriba un codigo");
    }

    if (VrHora <= 0) {
        alert("Error, escriba una valor adecuado");
    }

    if (CantHoras <= 0) {
        alert("Error, escriba una cantidad de horas adecuadas");
    }

    if (Recargo1 <= 0) {
        alert("Error, escriba un recargo1 valido");
    }

    if (Recargo2 <= 0) {
        alert("Error, escriba un recargo2 valido");
    }
    if (CantDom <= 0) {
        alert("Error, escriba un domicilio valido");
    }
    if (ValorDom <= 0) {
        alert("Error, escriba un valor de domicilio adecuado");
    }

    alert("VrHora: " + VrHora + ", CantHoras" + CantHoras + ", Recargo1" + Recargo1 + ", Recargo2" + Recargo2 + ", CantDom" + CantDom + ", ValorDom" + ValorDom);

        // Crear la estructura Json, con los datos de entrada deben coincidir los nombres de las propiedades del modelo
        let datosOut = {
            vrHora: VrHora,
            cantHorW: CantHoras,
            x: Recargo1,
            h: Recargo2,
            cantDomi: CantDom,
            vrXDomic: ValorDom
        }
    
        //Invocar al servicio
        // Enviar info y recuperar respuestas
        try {
            const retornoSrv = await fetch(dir + "parcial3",
                {
                    method: "POST",
                    mode: "cors",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify(datosOut)
                }
            ); //JSON.stringify
    
            const Rpta = await retornoSrv.json()
            console.log(Rpta);
            //En la constante Rpta
            $("#txtSalNorm").val(Rpta.salNom);
            $("#txtSalExth16").val(Rpta.salExtHasta16);
            $("#txtSalExtd16").val(Rpta.salExtMas16);
            $("#txtSubTot").val(Rpta.subTot);
            $("#txtPagoDom").val(Rpta.vrDomic);
            $("#txtTotal").val(Rpta.aPag);
        }
        catch (e) {
            alert("Error, " + e);
        }
}
        
