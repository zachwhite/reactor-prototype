public static class MOLECULES
{
	public static Molecule WATER = new Molecule ("Water",
		new Atom[] { 
			ATOMS.HYDROGEN, ATOMS.HYDROGEN, 
			ATOMS.OXYGEN 
		});

	public static Molecule AMMONIA = 
		new Molecule ("Ammonia", new Atom[] { 
			ATOMS.NITROGEN, 
			ATOMS.HYDROGEN, ATOMS.HYDROGEN, ATOMS.HYDROGEN 
		});

	public static Molecule HYDROCHLORIC_ACID =
		new Molecule ("Hydrochloric Acid", new Atom[] {
			ATOMS.HYDROGEN,
			ATOMS.CHLORINE
		});

	public static Molecule SULFURIC_ACID =
		new Molecule ("Sulfuric Acid", new Atom[] {
			ATOMS.HYDROGEN, ATOMS.HYDROGEN,
			ATOMS.SULFUR,
			ATOMS.OXYGEN, ATOMS.OXYGEN, ATOMS.OXYGEN, ATOMS.OXYGEN
		});
}