<?php
    try {
        $linkpdo = new PDO ( 'mysql:host='. Parametres::getHost().';port='. Parametres::getPort() .';dbname='. Parametres::getDbname().';charset=utf8', Parametres::getLogin(), Parametres::getPwd());
        //"server=localhost;user=root;database=easlille;port=3308;ssl mode=none"
       
    }
    catch(Exception $e){
        die('Erreur : '.$e->getMessage());
    }
    if (empty($_POST['lastId'])){
        $res = $linkpdo->prepare('SELECT * FROM messages ORDER BY IdMessage DESC LIMIT 10');
        $res->execute(array());
        while ($data = $res->fetch()) {
            $message[]=$data[4];
            $auteur[]=$data[3];
            $heure[]=$data[2];
            $dates[]=$data[1];
            $idMessage[]=$data[0];
        }
        for($i = count($idMessage)-1 ; $i >= 0 ; $i=$i-1){
                    echo ("<table class="."'msg'"."id=".$idMessage[$i].">
                        <tr>
                            <td><img id="."'image'"." src="."'./IMG/correspondant.png'"." alt="."'correspondant'"."/></td>
                                <td id="."'boite'".">".$message[$i]."
                            </td>
                        </tr>
                        </table>
                        <table id="."'metadata'".">
                            <tr>
                                <td>Le ".$dates[$i]." à ".$heure[$i]." - ".$auteur[$i]."</td>
                            </tr>
                        </table>");
                
        }
    } else {
        $res = $linkpdo->prepare('SELECT * FROM messages ORDER BY IdMessage DESC LIMIT 10');
        $res->execute(array());
        while ($data = $res->fetch()) {
            $message[]=$data[4];
            $auteur[]=$data[3];
            $heure[]=$data[2];
            $dates[]=$data[1];
            $idMessage[]=$data[0];
        }
        for($i = count($idMessage)-1 ; $i >= 0 ; $i=$i-1){
            if ($idMessage[$i]>$_POST['lastId']){
                 echo ("<table class="."'msg'"."id=".$idMessage[$i].">
                <tr>
                    <td><img id="."'image'"." src="."'./IMG/correspondant.png'"." alt="."'correspondant'"."/></td>
                        <td id="."'boite'".">".$message[$i]."
                    </td>
                </tr>
                </table>
                <table id="."'metadata'".">
                    <tr>
                        <td>Le ".$dates[$i]." à ".$heure[$i]." - ".$auteur[$i]."</td>
                    </tr>
                </table>");
            }       
        }
    }
    
    $res->closeCursor();
?>