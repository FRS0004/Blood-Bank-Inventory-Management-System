<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body bgcolor="cornflowerblue">

    <div class="tab-content">
        <div id="rbcs" data-tab-content>
            <h2>RBCs Inventory</h2>
            <div>
                <style>
                table,
                th,
                td {
                    padding: 10px;
                    border: 1px solid black;
                    border-collapse: collapse;
                }

                tr:nth-child(even) {
                    background-color: lightskyblue;
                }

                tr:nth-child(odd) {
                    background-color: white;
                }

                ul {
                    line-height: 300%;
                }
                </style>

                <table id="table">
                    <tr>
                        <th>DIN</th>
                        <th>ABO</th>
                        <th>Product_Code</th>
                        <th>Expiration_Date</th>
                        <th>Holds</th>
                        <th>Location</th>
                    </tr>

                    <?php

                        $search = $_POST['search'];

                        $connection = mysqli_connect("localhost", "root", "", "inventory");
                        if ($connection)
                        {
                            //echo "Connection is successful.";
                        }
                        else
                        {
                            die("Connection is unsuccessful: ".mysqli_connect_error());
                        }

                        $sql = "select * FROM rbcs WHERE DIN LIKE '%$search%' ";
                        $result = mysqli_query($connection, $sql);

                        if ($result-> num_rows > 0)
                        {
                            while ($row = $result-> fetch_assoc())
                            {
                                echo "<tr><td>". $row["DIN"] ."</td><td>". $row["ABO"] ."</td><td>". $row["Product_Code"] ."</td><td>". $row["Expiration_Date"] . "</td><td>". $row["Holds"] ."</td><td>". $row["Location"] ."</td></tr>";
                            }
                        }

                        echo "</table>";
                    ?>
                </table>
            </div>
        </div>


        <div id="tcps" data-tab-content>
            <h2>TCPs Inventory</h2>
            <div>
                <style>
                    table,
                    th,
                    td {
                        padding: 10px;
                        border: 1px solid black;
                        border-collapse: collapse;
                    }

                    tr:nth-child(even) {
                        background-color: lightskyblue;
                    }

                    tr:nth-child(odd) {
                        background-color: white;
                    }

                    ul {
                        line-height: 300%;
                    }
                </style>

                <table id="table">
                    <tr>
                        <th>DIN</th>
                        <th>ABO</th>
                        <th>Product_Code</th>
                        <th>Expiration_Date</th>
                        <th>Holds</th>
                        <th>Location</th>
                    </tr>

                    <?php

                        $search = $_POST['search'];

                        $connection = mysqli_connect("localhost", "root", "", "inventory");
                        if ($connection)
                        {
                            //echo "Connection is successful.";
                        }
                        else
                        {
                            die("Connection is unsuccessful: ".mysqli_connect_error());
                        }

                        $sql = "select * FROM platelets WHERE DIN LIKE '%$search%' ";
                        $result = mysqli_query($connection, $sql);

                        if ($result-> num_rows > 0)
                        {
                            while ($row = $result-> fetch_assoc())
                            {
                                echo "<tr><td>". $row["DIN"] ."</td><td>". $row["ABO"] ."</td><td>". $row["Product_Code"] ."</td><td>". $row["Expiration_Date"] . "</td><td>". $row["Holds"] ."</td><td>". $row["Location"] ."</td></tr>";
                            }
                        }

                        echo "</table>";
                    ?>
                </table>
            </div>
        </div>

        <div id="frozen" data-tab-content>
            <h2>Frozen Inventory</h2>
            <div>
                <style>
                    table,
                    th,
                    td {
                        padding: 10px;
                        border: 1px solid black;
                        border-collapse: collapse;
                    }

                    tr:nth-child(even) {
                        background-color: lightskyblue;
                    }

                    tr:nth-child(odd) {
                        background-color: white;
                    }

                    ul {
                        line-height: 300%;
                    }
                </style>

                <table id="table">
                    <tr>
                        <th>DIN</th>
                        <th>ABO</th>
                        <th>Product_Code</th>
                        <th>Expiration_Date</th>
                        <th>Holds</th>
                        <th>Location</th>
                    </tr>

                    <?php

                        $search = $_POST['search'];

                        $connection = mysqli_connect("localhost", "root", "", "inventory");
                        if ($connection)
                        {
                            //echo "Connection is successful.";
                        }
                        else
                        {
                            die("Connection is unsuccessful: ".mysqli_connect_error());
                        }

                        $sql = "select * FROM frozen_plasma WHERE DIN LIKE '%$search%' ";
                        $result = mysqli_query($connection, $sql);

                        if ($result-> num_rows > 0)
                        {
                            while ($row = $result-> fetch_assoc())
                            {
                                echo "<tr><td>". $row["DIN"] ."</td><td>". $row["ABO"] ."</td><td>". $row["Product_Code"] ."</td><td>". $row["Expiration_Date"] . "</td><td>". $row["Holds"] ."</td><td>". $row["Location"] ."</td></tr>";
                            }
                        }

                        echo "</table>";
                    ?>
                </table>
            </div>
        </div>
    </div>

    <br></br>


    <f3><bottom><center>
        This is created by Foster Smith for learning how to work with HTML, JavaScript, CSS, and PHP.
    </center></bottom></f3>


</body>

</html>