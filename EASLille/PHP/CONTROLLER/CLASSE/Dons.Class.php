<?php

class Dons 
{

	/*****************Attributs***************** */

	private $_IdDon;
	private $_Nom;
	private $_Prenom;
	private $_LibelleDon;
	private $_MontantDon;
	private static $_attributes=["IdDon","Nom","Prenom","LibelleDon","MontantDon"];
	/***************** Accesseurs ***************** */


	public function getIdDon()
	{
		return $this->_IdDon;
	}

	public function setIdDon(?int $IdDon)
	{
		$this->_IdDon=$IdDon;
	}

	public function getNom()
	{
		return $this->_Nom;
	}

	public function setNom(?string $Nom)
	{
		$this->_Nom=$Nom;
	}

	public function getPrenom()
	{
		return $this->_Prenom;
	}

	public function setPrenom(?string $Prenom)
	{
		$this->_Prenom=$Prenom;
	}

	public function getLibelleDon()
	{
		return $this->_LibelleDon;
	}

	public function setLibelleDon(?string $LibelleDon)
	{
		$this->_LibelleDon=$LibelleDon;
	}

	public function getMontantDon()
	{
		return $this->_MontantDon;
	}

	public function setMontantDon(?float $MontantDon)
	{
		$this->_MontantDon=$MontantDon;
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
		return "IdDon : ".$this->getIdDon()."Nom : ".$this->getNom()."Prenom : ".$this->getPrenom()."LibelleDon : ".$this->getLibelleDon()."MontantDon : ".$this->getMontantDon()."\n";
	}
}