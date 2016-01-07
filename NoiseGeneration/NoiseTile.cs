using NDimensionalArray;

namespace NoiseGeneration
{
	public struct NoiseTile
	{
		//TODO: generalise to INDArray
		public INDArray<int> data; //Noise data. Pixel/Voxel data with values ranging from 0 to 255. Side length of 2^n for best results.
		public INDArray<int> hash; //Hash values to seed noise data. Should be of side length 2^n + 1.
		//public int seed;

		public NoiseTile (int dim, int data_resolution, int hash_resolution){
			data = new NDArrayRegular<int> (dim, data_resolution);
			hash = new NDArrayRegular<int> (dim, hash_resolution);
		}
	}

	public enum TILE_TYPE
	{
		TYPE_LATTICE, TYPE_POINT
	}
}