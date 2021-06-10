

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <script src="script.js" defer></script>
    <link href="styles.css" rel="stylesheet">
    <title>Inventory Management</title>
</head>
<body bgcolor = "cornflowerblue">

    <h6 class="header">Inventory Management</h6>

    <form class="search_bar" action="SearchInventory.php" method="post">
        <input type="text" name="search" placeholder="Search Inventory">
        <input type="Submit">
    </form>

    <ul class="tabs">
        <button data-tab-target="#rbcs" class="tab">RBCs Inventory</button>
        <button data-tab-target="#tcps" class="tab">TCPs Inventory</button>
        <button data-tab-target="#frozen" class="tab">Frozen Inventory</button>
    </ul>
    
    <div class="tab-content">
        <div id="rbcs" data-tab-content>
            <h1>RBCs Inventory</h1>
            <div>
                <style>
                    table,
                    th,
                    td 
                    {
                        padding: 10px;
                        border: 1px solid black;
                        border-collapse: collapse;
                    }

                    tr:nth-child(even)
                    {
                        background-color: lightskyblue;
                    }

                    tr:nth-child(odd)
                    {
                        background-color: white;
                    }

                    ul
                    {
                        line-height: 300%;
                    }
                </style>

                <table id = "table">
                    <tr>
                        <th>DIN</th>
                        <th>ABO</th>
                        <th>Product_Code</th>
                        <th>Expiration_Date</th>
                        <th>Holds</th>
                        <th>Location</th>
                    </tr>

                    <?php

                        $connection = mysqli_connect("localhost", "root", "", "inventory");
                        if ($connection)
                        {
                            //echo "Connection is successful.";
                        }
                        else
                        {
                            die("Connection is unsuccessful: ".mysqli_connect_error());
                        }

                        $sql = "select DIN, ABO, Product_Code, Expiration_Date, Holds, Location FROM rbcs";
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
            <h1>TCPs Inventory</h1>
            <p>
                <style>
                    table,
                    th,
                    td 
                    {
                        padding: 10px;
                        border: 1px solid black;
                        border-collapse: collapse;
                    }

                    tr:nth-child(even)
                    {
                        background-color: lightskyblue;
                    }

                    tr:nth-child(odd)
                    {
                        background-color: white;
                    }

                    ul
                    {
                        line-height: 300%;
                    }
                </style>

                <table id = "table">
                    <tr>
                        <th>DIN</th>
                        <th>ABO</th>
                        <th>Product_Code</th>
                        <th>Expiration_Date</th>
                        <th>Holds</th>
                        <th>Location</th>
                    </tr>

                    <?php

                        $connection = mysqli_connect("localhost", "root", "", "inventory");
                        if ($connection)
                        {
                            //echo "Connection is successful.";
                        }
                        else
                        {
                            die("Connection is unsuccessful: ".mysqli_connect_error());
                        }

                        $sql = "select DIN, ABO, Product_Code, Expiration_Date, Holds, Location FROM platelets";
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
            </p>

        </div>

        <div id="frozen" data-tab-content>
            <h1>Frozen Inventory</h1>
            <p>
                <style>
                    table,
                    th,
                    td 
                    {
                        padding: 10px;
                        border: 1px solid black;
                        border-collapse: collapse;
                    }

                    tr:nth-child(even)
                    {
                        background-color: lightskyblue;
                    }

                    tr:nth-child(odd)
                    {
                        background-color: white;
                    }

                    ul
                    {
                        line-height: 300%;
                    }
                </style>

                <table id = "table">
                    <tr>
                        <th>DIN</th>
                        <th>ABO</th>
                        <th>Product_Code</th>
                        <th>Expiration_Date</th>
                        <th>Holds</th>
                        <th>Location</th>
                    </tr>

                    <?php

                        $connection = mysqli_connect("localhost", "root", "", "inventory");
                        if ($connection)
                        {
                            //echo "Connection is successful.";
                        }
                        else
                        {
                            die("Connection is unsuccessful: ".mysqli_connect_error());
                        }

                        $sql = "select DIN, ABO, Product_Code, Expiration_Date, Holds, Location FROM frozen_plasma";
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
            </p>
        </div>

    </div>


    <br></br>


    <f3><bottom><center>
        This is created by Foster Smith for learning how to work with HTML, JavaScript, CSS, and PHP.
    </center></bottom></f3>
    
</body>
</html>