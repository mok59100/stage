<?php

class Adhesions 
{

	/*****************Attributs***************** */

	private $_IdAdhesion;
	private $_DateDebutAdhesion;
	private $_DateFinAdhesion;
	private $_IdUtilisateur;
	private static $_attributes=["IdAdhesion","DateDebutAdhesion","DateFinAdhesion","IdUtilisateur"];
	/***************** Accesseurs ***************** */


	public function getIdAdhesion()
	{
		return $this->_IdAdhesion;
	}

	public function setIdAdhesion(?int $IdAdhesion)
	{
		$this->_IdAdhesion=$IdAdhesion;
	}

	public function getDateDebutAdhesion()
	{
		return is_null($this->_DateDebutAdhesion)?null:$this->_DateDebutAdhesion->format('Y-n-j');
	}

	public function setDateDebutAdhesion(?string $DateDebutAdhesion)
	{
		$this->_DateDebutAdhesion=is_null($DateDebutAdhesion)?null:DateTime::createFromFormat("Y-n-j",$DateDebutAdhesion);
	}

	public function getDateFinAdhesion()
	{
		return is_null($this->_DateFinAdhesion)?null:$this->_DateFinAdhesion->format('Y-n-j');
	}

	public function setDateFinAdhesion(?string $DateFinAdhesion)
	{
		$this->_DateFinAdhesion=is_null($DateFinAdhesion)?null:DateTime::createFromFormat("Y-n-j",$DateFinAdhesion);
	}

	public function getIdUtilisateur()
	{
		return $this->_IdUtilisateur;
	}

	public function setIdUtilisateur(?int $IdUtilisateur)
	{
		$this->_IdUtilisateur=$IdUtilisateur;
	}

	public static function getAttributes()
	{
		return self::$_attributes;
	}

	/*****************Constructeur***************** */

	public function __construct(array $options = [])
	{
 		if (!empty($options)) // empty : renvoi vrai si le tableau est vide
		{
			$this->hydrate($options);
		}
	}
	public function hydrate($data)
	{
 		foreach ($data as $key => $value)
		{
 			$methode = "set".ucfirst($key); //ucfirst met la 1ere lettre en majuscule
			if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
			{
				$this->$methode($value===""?null:$value);
			}
		}
	}

	/*****************Autres Méthodes***************** */

	/**
	* Transforme l'objet en chaine de caractères
	*
	* @return String
	*/
	public function toString()
	{
		return "IdAdhesion : ".$this->getIdAdhesion()."DateDebutAdhesion : ".$this->getDateDebutAdhesion()."DateFinAdhesion : ".$this->getDateFinAdhesion()."IdUtilisateur : ".$this->getIdUtilisateur()."\n";
	}
}