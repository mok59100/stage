<?php

class Videos 
{

	/*****************Attributs***************** */

	private $_IdVideo;
	private $_Description;
	private $_Videos;
	private static $_attributes=["IdVideo","Description","Videos"];
	/***************** Accesseurs ***************** */


	public function getIdVideo()
	{
		return $this->_IdVideo;
	}

	public function setIdVideo(?int $IdVideo)
	{
		$this->_IdVideo=$IdVideo;
	}

	public function getDescription()
	{
		return $this->_Description;
	}

	public function setDescription(?string $Description)
	{
		$this->_Description=$Description;
		
	}

	public function getVideos()
	{
		return $this->_Videos;
	}

	public function setVideos(?string $Videos)
	{
		$this->_Videos=$Videos;
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
		return "IdVideo : ".$this->getIdVideo()."Description : ".$this->getDescription()."Videos : ".$this->getVideos()."\n";
	}
}