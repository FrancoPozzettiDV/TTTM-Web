function validarForm() {
    var x = document.forms["miForm"]["userUsuario"].value;
    var y = document.forms["miForm"]["passUsuario"].value;
    if (x === "" || y === "" || (x === "" && y === "")) {
        alert("Por favor, ingrese todos los datos");
        return false;
    }
}