<?php

class Contient 
{

	/*****************Attributs***************** */

	private $_IdActualite;
	private $_IdImage;
	private static $_attributes=["IdActualite","IdImage"];
	/***************** Accesseurs ***************** */


	public function getIdActualite()
	{
		return $this->_IdActualite;
	}

	public function setIdActualite(int $IdActualite)
	{
		$this->_IdActualite=$IdActualite;
	}

	public function getIdImage()
	{
		return $this->_IdImage;
	}

	public function setIdImage(int $IdImage)
	{
		$this->_IdImage=$IdImage;
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
		return "IdActualite : ".$this->getIdActualite()."IdImage : ".$this->getIdImage()."\n";
	}
}