// #region [ Propriedades ]
var txtMensagem = document.getElementById("txtMensagem");
var txtNome = document.getElementById("txtNome");
var txtAssunto = document.getElementById("txtAssunto");
var txtMensagemEmail = document.getElementById("txtMensagemEmail");
// #endregion [ Propriedades ]

$(document).ready(function () {

});

// #region [ Eventos ]
function onClick_AlternarEntreEnvios(codigo) {
    if (codigo == 1) {
        $("#divEnvioDeEmail").css("display", "inline");
        $("#divEnvioWhatsapp").css("display", "none");
    } else {
        $("#divEnvioDeEmail").css("display", "none");
        $("#divEnvioWhatsapp").css("display", "inline");
    }
}

function onClick_EnviarMensagemWhatsapp() {
    if (txtMensagem.value != "") {
        $("#linkWhats").prop("href", `https://wa.me/5514999074567?text=${txtMensagem.value.replace(" ", "%20")}`);
    } else {
        tata.error('Erro', 'Por favor, escreva sua mensagem!', {
            position: 'tm',
            duration: 3000,
            animate: 'slide'
        });
    }
}
// #endregion [ Eventos ]

// #region [ Metodos ]
// #endregion [ Metodos ]