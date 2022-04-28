<?php

class AdhesionsManager 
{

	public static function add(Adhesions $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Adhesions $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Adhesions $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Adhesions::getAttributes(),"Adhesions",["IdAdhesion" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Adhesions::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Adhesions",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}