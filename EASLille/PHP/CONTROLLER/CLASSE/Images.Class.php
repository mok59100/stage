<?php

class Images 
{

	/*****************Attributs***************** */

	private $_IdImage;
	private $_Description;
	private $_Images;

	private static $_attributes=["IdImage","Description","Images"];
	/***************** Accesseurs ***************** */


	public function getIdImage()
	{
		return $this->_IdImage;
	}

	public function setIdImage(?int $IdImage)
	{
		$this->_IdImage=$IdImage;
	}

	public function getDescription()
	{
		return $this->_Description;
	}

	public function setDescription(?string $Description)
	{
		$this->_Description=$Description;
	}
	public function getImages()
	{
		return $this->_Images;
	}

	public function setImages(?string $Images)
	{
		$this->_Images=$Images;
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
		return "IdImage : ".$this->getIdImage()."Description : ".$this->getDescription()."Images : ".$this->getImages(). "\n";
	}
}