<?php
header('Content-Type: application/json');

$servername = "localhost";
$username = "ADMIN"; 
$password = "123"; 
$dbname = "QLBANHANGDIENLANH";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$sql = "SELECT * FROM orders";
$result = $conn->query($sql);

$orders = array();
while($row = $result->fetch_assoc()) {
    $orders[] = $row;
}

echo json_encode($orders);

$conn->close();
?>
