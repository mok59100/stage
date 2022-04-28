<?php

class ActualitesManager 
{

	public static function add(Actualites $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Actualites $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Actualites $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Actualites::getAttributes(),"Actualites",["IdActualite" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Actualites::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Actualites",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}