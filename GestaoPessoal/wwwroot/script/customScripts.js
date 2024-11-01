window.masks = () => {

    var phoneMask = IMask(
        document.getElementById('phone-mask'), {
        mask: '(00) 00000-0000'
    });

    var cpf = IMask(
        document.getElementById('cpf'), {
        mask: '000.000.000-00'
    });

    var cep = IMask(
        document.getElementById('cep'), {
        mask: '00000-000'
    });

};

