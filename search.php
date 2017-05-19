<!DOCTYPE html>
<html>

<body>
<?php
$servername = "4d28bcf8-5ca3-47f1-bc54-a771012fcc51.mysql.sequelizer.com";
$username = "gpsobmslthufejao";
$password = "UYL6M4ZWmEicc3WduMSWyW24KtjfTxmcbHktphdtT4wDvPx2CTYFMki77RttSTdW";
$dbname = "db4d28bcf85ca347f1bc54a771012fcc51";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

$sql = "SELECT * FROM OrderData";
$result = $conn->query($sql);

$sql= "SELECT o.CustomerID, o.OrderDate, o.OrderNumber, s.SiteName, p.Description, p.TypeURL FROM OrderData o JOIN OrderSite s ON o.OrderSite = s.ID JOIN ProductData p ON o.Type_ID = p.ID WHERE o.SerialNumber_ID = '".$q."'";

$result = mysqli_query($con,$sql);


while($row = mysqli_fetch_array($result)) {
echo "<table class='table table-hover table-striped'>";
echo "<tr>";
echo "<th>Owned By: </th>";
echo "<td>" . $row['CustomerID'] . "</td>";
echo "</tr>";
echo "<tr>";
echo "<th>Order Date: </th>";
echo "<td>" . $row['OrderDate'] . "</td>";
echo "</tr>";
echo "<tr>";
echo "<th>Order Number: </th>";
echo "<td>" . $row['OrderNumber'] . "</td>";
echo "</tr>";
echo "<tr>";
echo "<th>Site Used: </th>";
echo "<td>" . $row['SiteName'] . "</td>";
echo "</tr>";
echo "<tr>";
echo "<th>Ordered Item: </th>";
echo "<td>" . $row['Description'] . "</td>";
echo "</tr>";
echo "<tr>";
echo "<td colspan='2'>" . $row[TypeURL] . "</td>";
echo "</tr>";

}
echo "</table>";
mysqli_close($con);
?>
</body>
</html>