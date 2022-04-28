<?php

class CotisationsManager 
{

	public static function add(Cotisations $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Cotisations $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Cotisations $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Cotisations::getAttributes(),"Cotisations",["IdCotisation" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Cotisations::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Cotisations",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}