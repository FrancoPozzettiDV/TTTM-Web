$("#buscarUsuario").click(function () {

    var usuarioId = parseInt($("#usuarioIdConAjax").val());

    console.log(usuarioId);

    var json = {}
    json["id"] = usuarioId;

    console.log(json);

    $.ajax({
        type: "POST",
        url: "/Home/BuscarUsuarioConAjax",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify(json),

        success: function (response) {

            console.log(response);

            var response = JSON.parse(response);

            $("#usuario").html("" +
                "<p><h3>Usuario encontrado con AJAX</h3></p>" +
                "<p><b>ID: </b>" + response["id"] + "</p>" +
                "<p><b>Nombre: </b>" + response["nombre"] + "</p>" +
                "<p><b>Contraseña: </b>" + response["contraseña"] + "</p>" +
                "<p><b>Puntaje: </b>" + response["puntaje"] + "</p>" +
                "<p><b>Partidas Ganadas: </b>" + response["partidasGanadas"] + "</p>" +
                "<p><b>Partidas Jugadas: </b>" + response["partidasJugadas"] + "</p>" +
            "");

        }


    })

});