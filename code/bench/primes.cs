using System;

namespace Application
{
	public class Primes
	{
		public int prime_count;
		public int[] primes = new int[5000];

		public int getPrimeCount () { return this.prime_count; }
		public int getPrime (int i) { return this.primes[i]; }
		public void addPrime (int p) { this.primes[this.prime_count++] = p; }

		public bool isDivisible(int i, int by) { return (i % by) == 0; }

		public bool isPrimeDivisible(int candidate) {
			for (int i = 1; i < this.prime_count; ++i) {
				if (this.isDivisible(candidate, this.primes[i])) return true;
			}
			return false;
		}
	}

	public static class Programm {
		public static void Main() {
			Primes p = new Primes();
			int c = 1;
			while (p.getPrimeCount() < 5000) {
				if (!p.isPrimeDivisible(c)) {
					p.addPrime(c);
				}
				c++;
			}
			System.Console.WriteLine(p.getPrime(p.getPrimeCount() - 1));
		}
	}

}

