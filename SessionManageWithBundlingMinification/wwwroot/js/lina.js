function submitUserLoginForm() {
    var userName = document.getElementById('txtUserName');
    var password = document.getElementById('txtPassword');
    if (validateUserName(userName) && validatePassword(password)) {
        alert('Successfully Logined..!!')
    }
    else {
        alert('Please Enter Correct UN and PWD..!!')
    }
}