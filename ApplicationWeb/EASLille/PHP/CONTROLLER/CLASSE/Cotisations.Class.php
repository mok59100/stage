<?php

class Cotisations 
{

	/*****************Attributs***************** */

	private $_IdCotisation;
	private $_EtatCotisation;
	private $_MontantCotisation;
	private $_ModePaiement;
	private $_DateCotisation;
	private $_IdUtilisateur;
	private static $_attributes=["IdCotisation","EtatCotisation","MontantCotisation","ModePaiement","DateCotisation","IdUtilisateur"];
	/***************** Accesseurs ***************** */


	public function getIdCotisation()
	{
		return $this->_IdCotisation;
	}

	public function setIdCotisation(?int $IdCotisation)
	{
		$this->_IdCotisation=$IdCotisation;
	}

	public function getEtatCotisation()
	{
		return $this->_EtatCotisation;
	}

	public function setEtatCotisation(?string $EtatCotisation)
	{
		$this->_EtatCotisation=$EtatCotisation;
	}

	public function getMontantCotisation()
	{
		return $this->_MontantCotisation;
	}

	public function setMontantCotisation(?string $MontantCotisation)
	{
		$this->_MontantCotisation=$MontantCotisation;
	}

	public function getModePaiement()
	{
		return $this->_ModePaiement;
	}

	public function setModePaiement(?string $ModePaiement)
	{
		$this->_ModePaiement=$ModePaiement;
	}

	public function getDateCotisation()
	{
		return is_null($this->_DateCotisation)?null:$this->_DateCotisation->format('j-n-Y');
	}

	public function setDateCotisation(?string $DateCotisation)
	{
		$this->_DateCotisation=is_null($DateCotisation)?null:DateTime::createFromFormat("j-n-Y",$DateCotisation);
	}

	public function getIdUtilisateur()
	{
		return $this->_IdUtilisateur;
	}

	public function setIdUtilisateur(int $IdUtilisateur)
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
		return "IdCotisation : ".$this->getIdCotisation()."EtatCotisation : ".$this->getEtatCotisation()."MontantCotisation : ".$this->getMontantCotisation()."ModePaiement : ".$this->getModePaiement()."DateCotisation : ".$this->getDateCotisation()."IdUtilisateur : ".$this->getIdUtilisateur()."\n";
	}
}