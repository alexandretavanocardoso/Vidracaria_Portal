$(document).ready(function () {
    $('.nav_btn').click(function () {
        $('.mobile_nav_items').slideToggle().toggleClass('active');
    });

    onClick_ManipularSidebarWeb();
    onClick_ManipularSidebarMobile();
});

function onClick_ManipularSidebarWeb() {
    $("#cadastros").click(function () {
        $("#divCadastros").slideToggle();
    });

    $("#servicos").click(function () {
        $("#divServicos").slideToggle();
    });

    $("#paginas").click(function () {
        $("#divPages").slideToggle();
    });
}

function onClick_ManipularSidebarMobile() {
    $("#cadastrosMobile").click(function () {
        $("#divCadastrosMobile").slideToggle();
    });

    $("#servicosMobile").click(function () {
        $("#divServicosMobile").slideToggle();
    });

    $("#paginasMobile").click(function () {
        $("#divPagesMobile").slideToggle();
    });
}