<?php

class DonsManager 
{

	public static function add(Dons $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Dons $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Dons $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Dons::getAttributes(),"Dons",["IdDon" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Dons::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Dons",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}