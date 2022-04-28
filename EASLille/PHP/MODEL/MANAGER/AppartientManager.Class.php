<?php

class AppartientManager 
{

	public static function add(Appartient $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Appartient $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Appartient $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Appartient::getAttributes(),"Appartient",["IdActualite" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Appartient::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Appartient",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}