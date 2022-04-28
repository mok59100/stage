<?php

class Actualites 
{

	/*****************Attributs***************** */

	private $_IdActualite;
	private $_Titre;
	private $_Contenu;
	private $_DateAffichage;
	
	private static $_attributes=["IdActualite","Titre","Contenu","DateAffichage"];
	/***************** Accesseurs ***************** */


	public function getIdActualite()
	{
		return $this->_IdActualite;
	}

	public function setIdActualite(?int $IdActualite)
	{
		$this->_IdActualite=$IdActualite;
	}

	public function getTitre()
	{
		return $this->_Titre;
	}

	public function setTitre(?string $Titre)
	{
		$this->_Titre=$Titre;
	}

	public function getContenu()
	{
		return $this->_Contenu;
	}

	public function setContenu(?string $Contenu)
	{
		$this->_Contenu=$Contenu;
	}

	public function getDateAffichage()
	{
		return is_null($this->_DateAffichage)?null:$this->_DateAffichage->format('Y-n-j');
	}

	public function setDateAffichage(?string $DateAffichage)
	{
		$this->_DateAffichage=is_null($DateAffichage)?null:DateTime::createFromFormat("Y-n-j",$DateAffichage);
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
		return "IdActualite : ".$this->getIdActualite()."Titre : ".$this->getTitre()."Contenu : ".$this->getContenu()."DateAffichage : ".$this->getDateAffichage()."\n";
	}
}