<?php

class Utilisateurs 
{

	/*****************Attributs***************** */

	private $_IdUtilisateur;
	private $_Nom;
	private $_Prenom;
	private $_AdresseMail;
	private $_MotDePasse;
    private $_TelephoneUtilisateur;
	private $_SituationProfessionnelle;
	private $_Active;
	private $_IdRole;
	private static $_attributes=["IdUtilisateur","Nom","Prenom","AdresseMail","MotDePasse","TelephoneUtilisateur","SituationProfessionnelle","Active","IdRole"];
	/***************** Accesseurs ***************** */


	public function getIdUtilisateur()
	{
		return $this->_IdUtilisateur;
	}

	public function setIdUtilisateur(?int $IdUtilisateur)
	{
		$this->_IdUtilisateur=$IdUtilisateur;
	}

	public function getNom()
	{
		return $this->_Nom;
	}

	public function setNom(string $Nom)
	{
		$this->_Nom=$Nom;
	}

	public function getPrenom()
	{
		return $this->_Prenom;
	}

	public function setPrenom(string $Prenom)
	{
		$this->_Prenom=$Prenom;
	}

	public function getAdresseMail()
	{
		return $this->_AdresseMail;
	}

	public function setAdresseMail(string $AdresseMail)
	{
		$this->_AdresseMail=$AdresseMail;
	}

	public function getMotDePasse()
	{
		return $this->_MotDePasse;
	}

	public function setMotDePasse(?string $MotDePasse)
	{
		$this->_MotDePasse=$MotDePasse;
	}



	public function getTelephoneUtilisateur()
	{
		return $this->_TelephoneUtilisateur;
	}

	public function setTelephoneUtilisateur(?int $TelephoneUtilisateur)
	{
		$this->_TelephoneUtilisateur=$TelephoneUtilisateur;
	}

	public function getSituationProfessionnelle()
	{
		return $this->_SituationProfessionnelle;
	}

	public function setSituationProfessionnelle(?string $SituationProfessionnelle)
	{
		$this->_SituationProfessionnelle=$SituationProfessionnelle;
	}

	public function getActive()
	{
		return $this->_Active;
	}

	public function setActive(?int $Active)
	{
		$this->_Active=$Active;
	}

	public function getIdRole()
	{
		return $this->_IdRole;
	}

	public function setIdRole(int $IdRole)
	{
		$this->_IdRole=$IdRole;
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
		return "IdUtilisateur : ".$this->getIdUtilisateur()."Nom : ".$this->getNom()."Prenom : ".$this->getPrenom()."AdresseMail : ".$this->getAdresseMail()."MotDePasse : ".$this->getMotDePasse()."TelephoneUtilisateur : ".$this->getTelephoneUtilisateur()."SituationProfessionnelle : ".$this->getSituationProfessionnelle()."Active : ".$this->getActive()."IdRole : ".$this->getIdRole()."\n";
	}
}