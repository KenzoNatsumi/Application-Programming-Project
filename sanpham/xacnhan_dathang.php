<?php
$servername = "localhost";
$username = "ADMIN";
$password = "123";
$dbname = "QLBANHANGDIENLANH";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$product_name = $_POST['product_name'];
$quantity = $_POST['quantity'];
$customer_name = $_POST['customer_name'];
$customer_email = $_POST['customer_email'];

$sql = "INSERT INTO orders (product_name, quantity, customer_name, customer_email)
VALUES ('$product_name', '$quantity', '$customer_name', '$customer_email')";

if ($conn->query($sql) === TRUE) {
    echo "Đơn đặt hàng đã được ghi nhận.";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

$conn->close();
?>
