<?php

class VideosManager 
{

	public static function add(Videos $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Videos $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Videos $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Videos::getAttributes(),"Videos",["IdVideo" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Videos::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Videos",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}