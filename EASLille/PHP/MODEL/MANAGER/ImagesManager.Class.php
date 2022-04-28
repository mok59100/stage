<?php

class ImagesManager 
{

	public static function add(Images $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Images $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Images $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Images::getAttributes(),"Images",["IdImage" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Images::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Images",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}