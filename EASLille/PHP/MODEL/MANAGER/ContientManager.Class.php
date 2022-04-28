<?php

class ContientManager 
{

	public static function add(Contient $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Contient $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Contient $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Contient::getAttributes(),"Contient",["IdActualite" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Contient::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Contient",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}