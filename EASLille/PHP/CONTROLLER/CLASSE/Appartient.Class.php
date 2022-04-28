<?php

class Appartient 
{

	/*****************Attributs***************** */

	private $_IdActualite;
	private $_IdVideo;
	private static $_attributes=["IdActualite","IdVideo"];
	/***************** Accesseurs ***************** */


	public function getIdActualite()
	{
		return $this->_IdActualite;
	}

	public function setIdActualite(int $IdActualite)
	{
		$this->_IdActualite=$IdActualite;
	}

	public function getIdVideo()
	{
		return $this->_IdVideo;
	}

	public function setIdVideo(int $IdVideo)
	{
		$this->_IdVideo=$IdVideo;
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
		return "IdActualite : ".$this->getIdActualite()."IdVideo : ".$this->getIdVideo()."\n";
	}
}