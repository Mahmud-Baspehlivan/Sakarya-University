function validate() {
    var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    var bool = false;
    if (document.myForm.name.value == "") {
        alert("Kullanıcı Adı Eksik!");
        document.myForm.name.focus();
        return false;
    }
    if (document.myForm.email.value == "") {
        alert("Email Eksik!");
        document.myForm.email.focus();
        return false;
    } else {
        if (document.myForm.email.value.match(mailformat)) {
            bool = true;
        }
    }
    if (document.myForm.sifre.value == "") {
        alert("Şifre Eksik!");
        document.myForm.sifre.focus();
        return false;
    }
    if (false == Number.isInteger(parseInt(Number(document.myForm.sifre.value)))) {
        alert("Sadece sayı girin!");
        document.myForm.sifre.focus();
        return false;
    }


    return bool;
}